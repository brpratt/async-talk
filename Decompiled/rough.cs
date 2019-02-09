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
        private sealed class <Archive>d__0 : IAsyncStateMachine
        {
            public int <>1__state;

            public AsyncTaskMethodBuilder<string> <>t__builder;

            public string name;

            public Archiver <>4__this;

            private string <contents>5__1;

            private string <path>5__2;

            private string <>s__3;

            private string <>s__4;

            private TaskAwaiter<string> <>u__1;

            private void MoveNext()
            {
                int num = <>1__state;
                string result;
                try
                {
                    TaskAwaiter<string> awaiter2;
                    TaskAwaiter<string> awaiter;
                    switch (num)
                    {
                        default:
                            Console.WriteLine("  Archiving " + name);
                            awaiter2 = <>4__this.Download(name).GetAwaiter();
                            if (!awaiter2.IsCompleted)
                            {
                                num = (<>1__state = 0);
                                <>u__1 = awaiter2;
                                <Archive>d__0 stateMachine = this;
                                <>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
                                return;
                            }
                            goto IL_0093;
                        case 0:
                            awaiter2 = <>u__1;
                            <>u__1 = default(TaskAwaiter<string>);
                            num = (<>1__state = -1);
                            goto IL_0093;
                        case 1:
                            {
                                awaiter = <>u__1;
                                <>u__1 = default(TaskAwaiter<string>);
                                num = (<>1__state = -1);
                                break;
                            }
                            IL_0093:
                            <>s__3 = awaiter2.GetResult();
                            <contents>5__1 = <>s__3;
                            <>s__3 = null;
                            Console.WriteLine("    Downloaded " + name);
                            awaiter = <>4__this.Save(name, <contents>5__1).GetAwaiter();
                            if (!awaiter.IsCompleted)
                            {
                                num = (<>1__state = 1);
                                <>u__1 = awaiter;
                                <Archive>d__0 stateMachine = this;
                                <>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                                return;
                            }
                            break;
                    }
                    <>s__4 = awaiter.GetResult();
                    <path>5__2 = <>s__4;
                    <>s__4 = null;
                    Console.WriteLine("    Saved " + name);
                    result = <path>5__2;
                }
                catch (Exception exception)
                {
                    <>1__state = -2;
                    <>t__builder.SetException(exception);
                    return;
                }
                <>1__state = -2;
                <>t__builder.SetResult(result);
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
        private sealed class <Download>d__2 : IAsyncStateMachine
        {
            public int <>1__state;

            public AsyncTaskMethodBuilder<string> <>t__builder;

            public string name;

            public Archiver <>4__this;

            private TaskAwaiter <>u__1;

            private void MoveNext()
            {
                int num = <>1__state;
                string result;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = Task.Delay(1000).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = (<>1__state = 0);
                            <>u__1 = awaiter;
                            <Download>d__2 stateMachine = this;
                            <>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = <>u__1;
                        <>u__1 = default(TaskAwaiter);
                        num = (<>1__state = -1);
                    }
                    awaiter.GetResult();
                    result = DateTime.Now.ToString();
                }
                catch (Exception exception)
                {
                    <>1__state = -2;
                    <>t__builder.SetException(exception);
                    return;
                }
                <>1__state = -2;
                <>t__builder.SetResult(result);
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
        private sealed class <Save>d__3 : IAsyncStateMachine
        {
            public int <>1__state;

            public AsyncTaskMethodBuilder<string> <>t__builder;

            public string name;

            public string contents;

            public Archiver <>4__this;

            private TaskAwaiter <>u__1;

            private void MoveNext()
            {
                int num = <>1__state;
                string result;
                try
                {
                    TaskAwaiter awaiter;
                    if (num != 0)
                    {
                        awaiter = Task.Delay(1000).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            num = (<>1__state = 0);
                            <>u__1 = awaiter;
                            <Save>d__3 stateMachine = this;
                            <>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = <>u__1;
                        <>u__1 = default(TaskAwaiter);
                        num = (<>1__state = -1);
                    }
                    awaiter.GetResult();
                    result = DateTime.Now.ToString();
                }
                catch (Exception exception)
                {
                    <>1__state = -2;
                    <>t__builder.SetException(exception);
                    return;
                }
                <>1__state = -2;
                <>t__builder.SetResult(result);
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

        [AsyncStateMachine(typeof(<Archive>d__0))]
        [DebuggerStepThrough]
        public Task<string> Archive(string name)
        {
            <Archive>d__0 stateMachine = new <Archive>d__0();
            stateMachine.<>4__this = this;
            stateMachine.name = name;
            stateMachine.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.<>1__state = -1;
            AsyncTaskMethodBuilder<string> <>t__builder = stateMachine.<>t__builder;
            <>t__builder.Start(ref stateMachine);
            return stateMachine.<>t__builder.Task;
        }

        public void Dispose()
        {
        }

        [AsyncStateMachine(typeof(<Download>d__2))]
        [DebuggerStepThrough]
        private Task<string> Download(string name)
        {
            <Download>d__2 stateMachine = new <Download>d__2();
            stateMachine.<>4__this = this;
            stateMachine.name = name;
            stateMachine.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.<>1__state = -1;
            AsyncTaskMethodBuilder<string> <>t__builder = stateMachine.<>t__builder;
            <>t__builder.Start(ref stateMachine);
            return stateMachine.<>t__builder.Task;
        }

        [AsyncStateMachine(typeof(<Save>d__3))]
        [DebuggerStepThrough]
        private Task<string> Save(string name, string contents)
        {
            <Save>d__3 stateMachine = new <Save>d__3();
            stateMachine.<>4__this = this;
            stateMachine.name = name;
            stateMachine.contents = contents;
            stateMachine.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
            stateMachine.<>1__state = -1;
            AsyncTaskMethodBuilder<string> <>t__builder = stateMachine.<>t__builder;
            <>t__builder.Start(ref stateMachine);
            return stateMachine.<>t__builder.Task;
        }
    }
}
