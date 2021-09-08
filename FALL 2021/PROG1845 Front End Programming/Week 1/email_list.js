const $ = selector => document.querySelector(selector)

const inputContent = event => {
    const email = $("#email").value;
    console.log(event.target.value)
}

const button = event => {
    const click = $("#button").target.value;
    console.log(click)
}