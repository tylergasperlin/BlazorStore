using System.Collections.Generic;
using BlazorStore.Components;
using BlazorStore.Models;

namespace BlazorStore.Pages
{
    public partial class ParentComponent
    {
    public string MessageParent { get; set; } = "I am from parent";

    public int Age { get; set; }

    public string Name { get; set; } = "Tyler Name";

    string buttonMessage = "default message";
    private void GetMessage(string m)
    {
        buttonMessage = m;
    }

    private TheChildComponent<Product> childComponentRef;

    void OnClick()
    {
        childComponentRef.Show();
    }

    bool isDisplayed = true;

    List<Product> productList = new List<Product> {
        new Product{ Id=1, Name="Dodge", Price=50000},
        new Product{ Id=2, Name="Chevy", Price=200000},
        new Product{ Id=3, Name="Jeep", Price=120000}    
    };
    }
}