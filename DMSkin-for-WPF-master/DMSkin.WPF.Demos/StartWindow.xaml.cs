using System.Collections.Generic;
using System.Windows;

namespace DMSkin.WPF.Demos
{
    public partial class StartWindow 
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void WPFConvertList_Loaded(object sender, RoutedEventArgs e)
        {
            List<MessageModel> models = new List<MessageModel>();
            for (int i = 0; i < 30; i++)
            {
                MessageModel model = new MessageModel();
                //model.CallBackTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.CallNature = "Call Nature";
                model.CompanyRole = "EE";
                model.DateTime = "2018-10-21 13:23:1" + i.ToString();
                model.ERID = i.ToString();
                //model.FirstCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.FirstCallResult = "OK";
                //model.FirstCSO = "Clerk";
                model.Function = "Funct";
                model.HKID_Membership = "HKID";
                model.Language = "C";
                model.Name = "Haley";
                //model.Operator = "Haley";
                //model.SecondCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.SecondCallResult = "OK";
                //model.SecondCSO = "Clerk";
                model.SpecialReturnCallTime = true;
                //model.Status = "Yes";
                //model.TargetFollowUpFrequency = "TargetFollowUpFrequency";
                model.Tel = "15991655524";
                //model.ThirdCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.ThirdCallResult = "ok";
                //model.ThirdCSO = "Haley" + i;
                model.Title = "Manager";
                model.Urgent = "Urgent";

                models.Add(model);
                
            }
            this.WPFConvertList.ItemsSource = models;
        }
    }
    public class MessageModel
    {
        public string DateTime { get; set; }
        public string Function { get; set; }
        public string CompanyRole { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string ERID { get; set; }
        public string HKID_Membership { get; set; }
        public string Tel { get; set; }
        public string Urgent { get; set; }
        public bool SpecialReturnCallTime { get; set; }
        //public string CallBackTime { get; set; }
        //public string CallNature { get; set; }
        //public string Operator { get; set; }
        //public string FirstCallDateTime { get; set; }
        //public string FirstCallResult { get; set; }
        //public string FirstCSO { get; set; }
        //public string SecondCallDateTime { get; set; }
        //public string SecondCallResult { get; set; }
        //public string SecondCSO { get; set; }
        //public string ThirdCallDateTime { get; set; }
        //public string ThirdCallResult { get; set; }
        //public string ThirdCSO { get; set; }
        //public string TargetFollowUpFrequency { get; set; }
        //public string Status { get; set; }
    }
}
