using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
namespace XamarinTrics.FormsGallery
{
    public class PickerDemo1 : ContentPage
    {
        List<Employee> emps = new List<Employee>
        {
            new Employee {EmpId=1,EmpName="karunakr" },
              new Employee {EmpId=2,EmpName="Nikhil" },
                  new Employee {EmpId=3,EmpName="Gomathy" },
                      new Employee {EmpId=4,EmpName="Srivalli" },
        };
        public PickerDemo1()
        {
            Title = "Picker Demo";
            Label header = new Label
            {
                Text = "Picker Demo",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Label outputLabel = new Label
            {
                Text = "Out Put",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Picker picker = new Picker
            {
                Title = "Select Employee",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            foreach (Employee emp in emps)
            {
                picker.Items.Add(emp.EmpName);
            }
            picker.SelectedIndexChanged += (sender, eveArgs) =>
            {
                if (picker.SelectedIndex == -1)
                {
                    outputLabel.Text = "Please select Employee";
                }
                else
                {
                    string colorName = picker.Items[picker.SelectedIndex];
                    outputLabel.Text = emps.FirstOrDefault(x => x.EmpName == colorName).EmpId.ToString();
                }
            };
            Content = new StackLayout
            {
                Children =
                {
                    header,
                    picker,
                    outputLabel
                }
            };
        }
    }
}
