using LeMaiApi.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : BaseController
    {
        private readonly IConfiguration _configuration;
        private readonly WebhookLogic _logic;
        public WebhookController(ILogger<WebhookController> logger,
            IConfiguration config) : base(logger)
        {
            _configuration = config;
            BaseLogicConnectionData connection = new BaseLogicConnectionData();
            connection.ConnectionString = _configuration["DefaultConnection"];
            connection.Schema = _configuration["DefaultSheme"];
            _logic = new WebhookLogic(connection);
        }
        [HttpPost(nameof(WebhookBest))]
        public async Task<IActionResult> WebhookBest([FromBody] WHBestInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "BEST"); }).ConfigureAwait(false);
            return Ok();
        }
        [HttpPost(nameof(WebhookJnt))]
        public async Task<IActionResult> WebhookJnt([FromBody] WHJNTInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "JNT"); }).ConfigureAwait(false);
            WHJNTOutput outJson = new WHJNTOutput();
            outJson.status = true;
            return Ok(outJson);
        }
        private async Task ProcessWebhook(string data, string provider)
        {
            await _logic.addWebhook(data, provider).ConfigureAwait(false);
        }

        [HttpPost(nameof(WebhookNinja))]
        public async Task<IActionResult> WebhookNinja([FromBody] WHNinjaInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "NINJA"); }).ConfigureAwait(false);
            return Ok();
        }

        [HttpPost(nameof(WebhookViettel))]
        public async Task<IActionResult> WebhookViettel([FromBody] WHViettelInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "VIETTEL"); }).ConfigureAwait(false);
            return Ok();
        }

        [HttpPost(nameof(WebhookBamboo))]
        public async Task<IActionResult> WebhookBamboo([FromBody] WHBambooInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "BAMBOO"); }).ConfigureAwait(false);
            return Ok();
        }
        [HttpPost(nameof(WebhookBambooWeight))]
        public async Task<IActionResult> WebhookBambooWeight([FromBody] WHBambooWeightInput input)
        {
            var bodyjson = JsonConvert.SerializeObject(input);
            Task.Run(async () => { await ProcessWebhook(bodyjson, "BAMBOOW"); }).ConfigureAwait(false);
            return Ok();
        }
    }
}
