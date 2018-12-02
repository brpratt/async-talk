using System;
using System.Threading.Tasks;

namespace Archive
{
    class CompiledArchiver : IDisposable
    {
        private class ArchiveStateMachine
        {
            enum State { Start, Download, Save }
            private TaskCompletionSource<string> _tcs;
            private CompiledArchiver _archiver;
            private string _name;
            private string _contents;
            private string _path;
            private Task<string> _downloadTask;
            private Task<string> _saveTask;
            private State _state = State.Start;

            public Task<string> Task
            { 
                get
                {
                    return _tcs.Task;
                }
            }

            public ArchiveStateMachine(CompiledArchiver archiver, string name)
            {
                _tcs = new TaskCompletionSource<string>();
                _archiver = archiver;
                _name = name;
            }

            public void MoveNext()
            {
                try
                {
                    switch (_state)
                    {
                        case State.Start:
                            Console.WriteLine($"  Archiving {_name}");
                            _downloadTask = _archiver.Download(_name);
                            _state = State.Download;
                            _downloadTask.ContinueWith(_ => MoveNext());
                            break;
                        case State.Download:
                            if (_downloadTask.IsFaulted)
                            {
                                _tcs.SetException(_downloadTask.Exception.InnerException);
                            }
                            else
                            {
                                _contents = _downloadTask.Result;
                                Console.WriteLine($"    Downloaded {_name}");

                                _saveTask = _archiver.Save(_name, _contents);
                                _state = State.Save;
                                _saveTask.ContinueWith(_ => MoveNext());
                            }
                            break;
                        case State.Save:
                            if (_saveTask.IsFaulted)
                            {
                                _tcs.SetException(_saveTask.Exception.InnerException);
                            }
                            else
                            {
                                _path = _saveTask.Result;
                                Console.WriteLine($"    Saved {_name}");
                                _tcs.SetResult(_path);
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    _tcs.SetException(e);
                }
            }
        }

        public Task<string> Archive(string name)
        {
            var sm = new ArchiveStateMachine(this, name);
            sm.MoveNext();
            return sm.Task;
        }

        public void Dispose()
        {

        }

        private async Task<string> Download(string name)
        {
            await Task.Delay(1000);
            return DateTime.Now.ToString();
        }

        private async Task<string> Save(string name, string contents)
        {
            await Task.Delay(1000);
            return DateTime.Now.ToString();
        }
    }
}
