function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorServerExample", "GetCurrentCount")
        .then(result => {
            console.log('Counter ' + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("Increment");
}