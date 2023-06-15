using Quartz.Impl;
using Quartz;

namespace SimpleTradeBot.Jobs
{
    public class TradeBotScheduler
    {

        public static async void Start()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            

            IJobDetail job = JobBuilder.Create<TradeBotStarter>().Build();

            ITrigger trigger = TriggerBuilder.Create()  // создаем триггер
                .WithIdentity("trigger1", "group1")     // идентифицируем триггер с именем и группой
                .StartNow()                            // запуск сразу после начала выполнения
                .WithSimpleSchedule(x => x            // настраиваем выполнение действия
                    .WithIntervalInMinutes(1)         // через 1 минуту
                    .RepeatForever())                   // бесконечное повторение
                .Build();                               // создаем триггер

            if (!scheduler.IsStarted)
            {
                await scheduler.ScheduleJob(job, trigger);        // начинаем выполнение работы
                await scheduler.Start();
            }
        }


        public static async void Stop()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Shutdown();

        }
    }
}
