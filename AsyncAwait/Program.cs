using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            CallerWithAsync();
            Console.ReadLine();
        }

        private static void CallerWithAwaiter()
        {
            TraceThreadAndTask($"starting {nameof(CallerWithAwaiter)}");
            TaskAwaiter<string> awaiter = GreetingAsync("Manpreet").GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                Console.WriteLine(awaiter.GetResult());
                TraceThreadAndTask($"ended {nameof(CallerWithAwaiter)}");
            });
        }

        private async static void CallerWithAsync()
        {
            TraceThreadAndTask($"started {nameof(CallerWithAsync)}");
            string result = await GreetingAsync("Manpreet");
            Console.WriteLine("Result value " + result);
            TraceThreadAndTask($"ended {nameof(CallerWithAsync)}");
        }

        static string Greeting(string name)
        {
            TraceThreadAndTask($"running {nameof(Greeting)}");

            Task.Delay(3000).Wait();

            return $"Hello, {name}";
        }

        static Task<string> GreetingAsync(string name) => Task.Run(() =>
        {
            TraceThreadAndTask($"running {nameof(GreetingAsync)}");
            return Greeting(name);
        });

        public static void TraceThreadAndTask(string info)
        {
            string taskInfo = Task.CurrentId == null ? "no task" : "task " + Task.CurrentId;

            Console.WriteLine($"{info} in thread {Thread.CurrentThread.ManagedThreadId} and {taskInfo}");
        }
    }
}
