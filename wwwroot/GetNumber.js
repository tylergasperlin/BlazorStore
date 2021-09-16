window.GetNumber = (i) => {
    var result = DotNet.invokeMethod("BlazorStore", "ReturnArray", i);
    document.getElementById("s1").innerHTML = result;
}