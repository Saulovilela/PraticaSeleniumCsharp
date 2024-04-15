using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Elements
{
    public class ComprandoMochilaElements
    {
        public const string ImageMochila = "//*[@id=\"item_4_img_link\"]/img";
        public const string BtnAddMochila = "//*[@id='inventory_container']/div/div[1]/div[3]/button";
        public const string BtnAddToCart = "//*[@id=\"inventory_item_container\"]/div/div/div/button";
        public const string BtnCart = "shopping_cart_container";
        public const string BtnCheckout = "//*[@id='cart_contents_container']/div/div[2]/a[2]";
        public const string FirstName = "first-name";
        public const string LastName = "last-name";
        public const string ZipCode = "postal-code";
        public const string BtnContinue = "//*[@id=\"checkout_info_container\"]/div/form/div[2]/input";
        public const string BtnFinish = "//*[@id=\"checkout_summary_container\"]/div/div[2]/div[8]/a[2]";
    }
}
