using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[module: UnverifiableCode]
namespace Archive
{
    internal class Archiver : IDisposable
    {
        [CompilerGenerated]
        private sealed class _Archive_d__0 : IAsyncStateMachine
        {
            public int __1__state;

            public AsyncTaskMethodBuilder<string> __t__builder;

            public string name;

            public Archiver __4__this;

            private string _contents_5__1;

            private string _path_5__2;

            private string __s__3;

            private string __s__4;

            private TaskAwaiter<string> __u__1;

            private void MoveNext()
            {
                int num = __1__state;
                string result;
                try
                {
                    TaskAwaiter<string> awaiter2;
                    TaskAwaiter<string> awaiter;
                    switch (num)
                    {
                        default:
                            Console.WriteLine("  Archiving " + name);
                            awaiter2 = __4__this.Download(name).GetAwaiter();
                            if (!awaiter2.IsCompleted)
                            {
                                num = (__1__state = 0);
                                __u__1 = awaiter2;
                                _Archive_d__0 stateMachine = this;
                                __t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
                                return;
                            }
                            goto IL_0093;
                        case 0:
                            awaiter2 = __u__1;
                            __u__1 = default(TaskAwaiter<string>);
                            num = (__1__state = -1);
                            goto IL_0093;
                        case 1:
                            {
                                awaiter = __u__1;
                                __u__1 = default(TaskAwaiter<string>);
                                num = (__1__state = -1);
                                break;
                            }
                            IL_0093:
                            __s__3 = awaiter2.GetResult();
                            _contents_5__1 = __s__3;
                            __s__3 = null;
                            Console.WriteLine("    Downloaded " + name);
                            awaiter = __4__this.Save(name, _contents_5__1).GetAwaiter();
                            if (!awaiter.IsCompleted)
                            {
                                num = (__1__state = 1);
                                __u__1 = awaiter;
                                _Archive_d__0 stateMachine = this;
                                __t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                                return;
                            }
                            break;
                    }
                    __s__4 = awaiter.GetResult();
                    _path_5__2 = __s__4;
                    __s__4 = null;
                    Console.WriteLine("    Saved " + name);
                    result = _path_5__2;
                }
                catch (Exception exception)
                {
                    __1__state = -2;
                    __t__builder.SetException(exception);
                    return;
                }
                __1__state = -2;
                __t__builder.SetResult(result);
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private sealed class _Download_d__2 : IAsyncStateMachine
        {
            public int __1__state;

            public AsyncTaskMethodBuilder<string> __t__builder;

            public string name;

            public Archiver __4__this;

            private TaskAwaiter __u__1;

            private void MoveNext()
            {
                int num = __1__state;
                string result;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = Task.Delay(1000).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = (__1__state = 0);
                            __u__1 = awaiter;
                            _Download_d__2 stateMachine = this;
                            __t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = __u__1;
                        __u__1 = default(TaskAwaiter);
                        num = (__1__state = -1);
                    }
                    awaiter.GetResult();
                    result = DateTime.Now.ToString();
                }
                catch (Exception exception)
                {
                    __1__state = -2;
                    __t__builder.SetException(exception);
                    return;
                }
                __1__state = -2;
                __t__builder.SetResult(result);
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [CompilerGenerated]
        private sealed class _Save_d__3 : IAsyncStateMachine
        {
            public int __1__state;

            public AsyncTaskMethodBuilder<string> __t__builder;

            public string name;

            public string contents;

            public Archiver __4__this;

            private TaskAwaiter __u__1;

            private void MoveNext()
            {
                int num = __1__state;
                string result;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = Task.Delay(1000).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = (__1__state = 0);
                            __u__1 = awaiter;
                            _Save_d__3 stateMachine = this;
                            __t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = __u__1;
                        __u__1 = default(TaskAwaiter);
                        num = (__1__state = -1);
                    }
                    awaiter.GetResult();
                    result = DateTime.Now.ToString();
                }
                catch (Exception exception)
                {
                    __1__state = -2;
                    __t__builder.SetException(exception);
                    return;
                }
                __1__state = -2;
                __t__builder.SetResult(result);
            }

            void IAsyncStateMachine.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                this.MoveNext();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                //ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
                this.SetStateMachine(stateMachine);
            }
        }

        [AsyncStateMachine(typeof(_Archive_d__0))]
        [DebuggerStepThrough]
        public Task<string> Archive(string name)
        {
            _Archive_d__0 stateMachine = new _Archive_d__0();
            stateMachine.__4__this = this;
            stateMachine.name = name;
            stateMachine.__t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.__1__state = -1;
            AsyncTaskMethodBuilder<string> __t__builder = stateMachine.__t__builder;
            __t__builder.Start(ref stateMachine);
            return stateMachine.__t__builder.Task;
        }

        public void Dispose()
        {
        }

        [AsyncStateMachine(typeof(_Download_d__2))]
        [DebuggerStepThrough]
        private Task<string> Download(string name)
        {
            _Download_d__2 stateMachine = new _Download_d__2();
            stateMachine.__4__this = this;
            stateMachine.name = name;
            stateMachine.__t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.__1__state = -1;
            AsyncTaskMethodBuilder<string> __t__builder = stateMachine.__t__builder;
            __t__builder.Start(ref stateMachine);
            return stateMachine.__t__builder.Task;
        }

        [AsyncStateMachine(typeof(_Save_d__3))]
        [DebuggerStepThrough]
        private Task<string> Save(string name, string contents)
        {
            _Save_d__3 stateMachine = new _Save_d__3();
            stateMachine.__4__this = this;
            stateMachine.name = name;
            stateMachine.contents = contents;
            stateMachine.__t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.__1__state = -1;
            AsyncTaskMethodBuilder<string> __t__builder = stateMachine.__t__builder;
            __t__builder.Start(ref stateMachine);
            return stateMachine.__t__builder.Task;
        }
    }
}
