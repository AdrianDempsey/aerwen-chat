using Infrastructure;
using Infrastructure.Attribute;
using Infrastructure.Enums;
using Infrastructure.Model;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ARW.Admin.WebApi.Extensions;
using ARW.Admin.WebApi.Filters;
using ARW.Common;
using ARW.Model.Dto.Business;
using ARW.Model.Models.Business;
using ARW.Service.Business.IBusinessService;
using ARW.Service.Business.IBusinessService.Crawler;
using ARW.Model.Dto.Business.Crawler;
using System.Configuration;

namespace ARW.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 爬虫控制器
    /// </summary>
    //[Verify]
    [Route("business/[controller]")]
    public class CrawlerController : BaseController
    {
        private readonly ICrawlService _crawlService;

        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="crawlService">学生服务</param>
        public CrawlerController(ICrawlService crawlService)
        {
            _crawlService = crawlService;
        }

        /// <summary>
        /// 获取爬虫列表
        /// </summary>
        /// <param name="parm">查询参数</param>
        /// <returns></returns>
        [HttpGet("getCrawlList")]
        public IActionResult GetCrawlist([FromQuery] CrawlQueryDto parm)
        {
            var res = _crawlService.GetBuxiuseList(parm);
            return SUCCESS(res);
        }

        /// <summary>
        /// 爬取数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("ParseCrawler")]
        public IActionResult ParseCrawler()
        {
            var crawler = AppSettings.App<CrawlerConfig>(new string[] { "CrawlerConfigs", "crawler" });

            var name = "yellow";
            _crawlService.DeleteTable();
            foreach (var config in crawler.Where(c => c.Name == name.ToLower()))
            {
                foreach (var host in config.Hosts)
                {
                    Console.WriteLine($"crawl {host} start.");
                    var html = _crawlService.LoadHTML(host);
                    if (string.IsNullOrEmpty(html))
                    {
                        return null;
                    }
                    var insert = _crawlService.ParseMovies(html);
                    if (insert == 0)
                    {
                        throw new CustomException("爬虫失败！");
                    }
                }
                Console.WriteLine("爬虫成功~");
            }
            return SUCCESS("爬虫成功！");
        }
    }
}
