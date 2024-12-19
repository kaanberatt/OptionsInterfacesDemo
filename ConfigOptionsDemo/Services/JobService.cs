using ConfigOptionsDemo.Models;
using Microsoft.Extensions.Options;

namespace ConfigOptionsDemo.Services
{
    public class JobService : BackgroundService
    {
        private CronValuesSettings _cronValuesSettings;
        public JobService(IOptionsMonitor<CronValuesSettings> optionsMonitor)
        {
            _cronValuesSettings = optionsMonitor.CurrentValue;

            optionsMonitor.OnChange(updatedSettings);
        }

        private void updatedSettings(CronValuesSettings settings, string? arg2)
        {
            _cronValuesSettings = settings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(true)
            {
                Console.WriteLine("Cron Values : " + _cronValuesSettings.Job1 + " " + _cronValuesSettings.Job2);

                await Task.Delay(TimeSpan.FromSeconds(10));
            }
        }
    }
}
