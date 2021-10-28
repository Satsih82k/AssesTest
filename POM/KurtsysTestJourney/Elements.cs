using OpenQA.Selenium;

namespace POM
{
    public class Elements
    {
        public static By Resourse_drpdn_loc = By.XPath("/html/body/div[1]/div/div/section/div/div/div[2]/div/div/div/div/div/div/div/ul/li[3]/div/div/div/div/section/div/div/div[2]/div/div/div[2]/div/ul/li[4]/a/span[2]");

        public static By White_Papers_eBooks_loc = By.XPath("((//span[normalize-space(@class)='menu-image-title' and normalize-space(text())='Resources']))[1]");

        public static By Click_Any_White_Papers_eBooks1_loc = By.XPath("/html/body/div[2]/div/div/section[2]/div/div/div/div/div/div/div/div");

        public static By Click_Any_White_Papers_eBooks2_loc = By.XPath("/html/body/div[2]/div/div/section[2]/div/div/div/div/div/div/div/div/article[2]/div/div[1]/p/a");

        public static By iframe_Form_loc = By.XPath("/html/body/div[2]/div/div/section/div/div/div/div/div/div/div/div/div/div/section[4]/div/div/div[2]/div/div/div[2]/div/iframe");

        //FirstName Text Field
        public static By FirstName_loc = By.Id("18882_241306pi_18882_241306");
        //LastName Text Field
        public static By LastName_loc = By.Id("18882_241308pi_18882_241308");
        //Email Text Field
        public static By email_loc = By.Id("18882_241310pi_18882_241310");
        //Company Text Field
        public static By company_loc = By.Id("18882_241312pi_18882_241312");
        //Industry Drop down
        public static By industry_loc = By.Id("18882_241314pi_18882_241314");
        //Click on Submit Button
        public static By submit_form_loc = By.XPath("/html/body/form/p[2]");

        public static By EmailError = (By.XPath("//*[@id='pardot-form']/div[3]/p"));

        public static By FiledError = (By.XPath("//*[@id='pardot-form']/p[1]"));
    }
}
