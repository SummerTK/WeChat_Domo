using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.Helpers;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.Card;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string accessToken = "11_jFGzse3a4wGPBq8cCTsKUMGabo2V_dmJVKHKiltmkNmhTSKHv8J6BaJ5nTQ6-eTeNhdh1LNNOcGEkbYelx6DlFaSx9wIcOIlaKGMMJujb9BptSNhWnDq7Vpyb_oQuFT_nYJpp7bOnT5ew1kESKBcACAMEV";

            var data1 = new Card_GrouponData()
            {
                base_info = _BaseInfo,
                deal_detail = "测试"
            };

            var result1 = CardApi.CreateCard(accessToken, data1);

            var data = new Card_MemberCardData()
            {
                base_info = _BaseInfo,
                supply_bonus = true,
                supply_balance = false,
                prerogative = "123123",
                bind_old_card_url = "www.daidu.com",
                wx_activate = true
            };

            var result = CardApi.CreateCard(accessToken, data);

           
            return new string[] { "value1", "value2" };
        }

        protected Card_BaseInfoBase _BaseInfo = new Card_BaseInfoBase()
        {
            logo_url = "http:\\www.supadmin.cn/uploads/allimg/120216/1_120216214725_1.jpg",
            brand_name = "海底捞",
            code_type = Card_CodeType.CODE_TYPE_TEXT,
            title = "132 元双人火锅套餐",
            sub_title = "周末狂欢必备",
            color = "Color010",
            notice = "使用时向服务员出示此券",
            service_phone = "020-88888888",
            description = @"不可与其他优惠同享\n 如需团购券发票，请在消费时向商户提出\n 店内均可
使用，仅限堂食\n 餐前不可打包，餐后未吃完，可打包\n 本团购券不限人数，建议2 人使用，超过建议人
数须另收酱料费5 元/位\n 本单谢绝自带酒水饮料",
            date_info = new Card_BaseInfo_DateInfo()
            {
                type = Card_DateInfo_Type.DATE_TYPE_PERMANENT.ToString(),
            },
            sku = new Card_BaseInfo_Sku()
            {
                quantity = 5
            },
            use_limit = 1,
            get_limit = 3,
            use_custom_code = false,
            bind_openid = false,
            can_share = true,
            can_give_friend = true,
            url_name_type = Card_UrlNameType.URL_NAME_TYPE_RESERVATION,
            custom_url = "http://www.weiweihi.com",
            source = "大众点评",
            custom_url_name = "立即使用",
            custom_url_sub_title = "6个汉字tips",
            promotion_url_name = "更多优惠",
            promotion_url = "http://www.qq.com",
        };


    }
}
