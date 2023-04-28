using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppliXamarinForm.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountPage : ContentPage
    {
        int count = 0;
        public CountPage()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            count++;
            LabelCompt.Text = count.ToString();
        }

        private void btnClickAjt(object sender, EventArgs e)
        {
            count++;
            LabelCompt.Text = count.ToString();
        }

        private void btnClickDel(object sender, EventArgs e)
        {
            
            if(count > 0)
            {
                count--;
            }
            LabelCompt.Text = count.ToString();
        }

        private void btnClickReset(object sender, EventArgs e)
        {
            count = 0;
            LabelCompt.Text = count.ToString();
        }
    }
}