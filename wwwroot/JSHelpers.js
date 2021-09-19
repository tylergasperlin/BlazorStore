window.GetNumber = (i) => {
    var result = DotNet.invokeMethod("BlazorStore", "ReturnArray", i);
    document.getElementById("s1").innerHTML = result;
}

window.GetSquareRoot = async (number) => {
    var result = await DotNet.invokeMethod("BlazorStore", "CalculateSquareRootAsync", parseInt(number));
    document.getElementById("s2").innerHTML = result.result;

}

const JSFunction = (name) => {
    const result = DotNet.invokeMethod('BlazorStore', 'FunctionCaller', name)
    alert(result)
}

function JSSayHello(obj) {
    const result = obj.invokeMethod("SayHello", "Welcome to the world");
    alert(result);
}