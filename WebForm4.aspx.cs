using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

namespace CachingDemo
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = ans.ToString();
            //Cache["answer"] = TextBox3.Text;
            //Cache.Add("answer", TextBox3.Text, null, 
            //    Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(10),CacheItemPriority.Default, null);

            //CacheItemRemovedCallback cb = new CacheItemRemovedCallback(removing);

            //2.10.20pm---- 
            //    10--absolute expiration-----2.10.30pm
            //    10--sliding----2.10.24pm----2.10.34pm


            //--absolute----exact time the cache will outdated
            //    --sliding ----- 
        }
        private void removing(string key, object val, CacheItemRemovedReason r)
        {
            r=CacheItemRemovedReason.DependencyChanged;
            TextBox5.Text = r.ToString();
            Response.Write(TextBox5.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          //  TextBox4.Text = Cache["answer"].ToString();
            TextBox4.Text = Cache.Get("answer").ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CacheDependency dep = new CacheDependency(@"D:\Sulakshana\198-Mphasis\CachingDemo\CachingDemo\Demo.txt");

            string fname= @"D:\Sulakshana\198-Mphasis\CachingDemo\CachingDemo\Demo.txt";
            Cache.Add("myfile",fname , dep,DateTime.Now.AddSeconds(1),Cache.NoSlidingExpiration, CacheItemPriority.High, new CacheItemRemovedCallback(removing));

        }
    }
}