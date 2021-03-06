﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
namespace Smairo.Template.ConsoleApp
{
    public class ApplicationName : IApplicationName
    {
        private readonly ILogger<ApplicationName> _logger;
        public ApplicationName(ILogger<ApplicationName> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("Hello world!");

            Console.WriteLine("Console closing. Press anything to quit");
            Console.ReadKey();
        }
    }

    public interface IApplicationName
    {
        Task RunAsync();
    }
}