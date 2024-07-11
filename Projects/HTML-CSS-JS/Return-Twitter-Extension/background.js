function replaceX() {
  // Replace Favicon
  replaceFavicon();

  // Replace Document Title
  replaceTitle();

  // Replace SVGs
  replaceSVGs();

  // Replace Texts
  replaceTexts();

  // Delete "Premium" Button
  deletePremiumButton();

  // Delete "Subscribe to Premium" Button
  deleteSubscribeButton();
}

const readyStateCheckInterval = setInterval(function () {
  if (document.readyState === "complete") {
    clearInterval(readyStateCheckInterval);
    const observer = new MutationObserver(replaceX);
    observer.observe(document.body, { childList: true, subtree: true });
  }
}, 10);

// Replace Favicon
function replaceFavicon() {
  const birdFavicon = "https://abs.twimg.com/favicons/twitter.2.ico";
  document.querySelector("link[rel~='icon']").href = birdFavicon;
}

// Replace Document Title
const xTitleRegex = /\/ X$/g;
function replaceTitle() {
  document.title = document.title.replace(xTitleRegex, "/ Twitter");
}

// Delete "Premium" Button
function deletePremiumButton() {
  document.querySelectorAll(`a`).forEach(a => {
    if (a.getAttribute("aria-label") == "Premium") {
      a.remove()
    }
    if (a.textContent == "Upgrade to get verified") {
      a.remove()
    }
  })
}

// Delete "Subscribe to Premium" Button
function deleteSubscribeButton() {
  document.querySelectorAll(`aside`).forEach(aside => {
    if (aside.getAttribute("aria-label") == "Subscribe to Premium") {
      const parent = aside.parentNode;
      parent.remove();
    }
  })
}

// Replace Texts
function replaceTexts() {
  document.querySelectorAll(`span`).forEach(span => {
    if (span.textContent == "Post") {
      span.textContent = "Tweet"
    }
    if (span.textContent == "Posts") {
      span.textContent = "Tweets"
    }
    if (span.textContent == "Add another post") {
      span.textContent = "Add another tweet"
    }
    if (span.textContent == "You must be subscribed to Premium to highlight posts on your profile.") {
      span.textContent = "You must be subscribed to Premium to highlight tweets on your profile."
    }
    if (span.textContent == "Repost") {
      span.textContent = "Retweet"
    }
    if (span.textContent == "Share post via …") {
      span.textContent = "Share tweet via …"
    }
    if (span.textContent == "This account is verified because it's an official organization on X. ") {
      span.textContent = "This account is verified because it's an official organization on Twitter. "
    }
    if (span.textContent == " on X. ") {
      span.textContent = " on Twitter. "
    }
    if (span.textContent == "Live on X") {
      span.textContent = "Live on Twitter"
    }
  })
}

// Replace SVGs
// SVGs
// Bird
const xPath = "M18.244 2.25h3.308l-7.227 8.26 8.502 11.24H16.17l-5.214-6.817L4.99 21.75H1.68l7.73-8.835L1.254 2.25H8.08l4.713 6.231zm-1.161 17.52h1.833L7.084 4.126H5.117z";
const birdPath = "M23.643 4.937c-.835.37-1.732.62-2.675.733.962-.576 1.7-1.49 2.048-2.578-.9.534-1.897.922-2.958 1.13-.85-.904-2.06-1.47-3.4-1.47-2.572 0-4.658 2.086-4.658 4.66 0 .364.042.718.12 1.06-3.873-.195-7.304-2.05-9.602-4.868-.4.69-.63 1.49-.63 2.342 0 1.616.823 3.043 2.072 3.878-.764-.025-1.482-.234-2.11-.583v.06c0 2.257 1.605 4.14 3.737 4.568-.392.106-.803.162-1.227.162-.3 0-.593-.028-.877-.082.593 1.85 2.313 3.198 4.352 3.234-1.595 1.25-3.604 1.995-5.786 1.995-.376 0-.747-.022-1.112-.065 2.062 1.323 4.51 2.093 7.14 2.093 8.57 0 13.255-7.098 13.255-13.254 0-.2-.005-.402-.014-.602.91-.658 1.7-1.477 2.323-2.41z";
// House
// const xHouse = "M21.591 7.146L12.52 1.157c-.316-.21-.724-.21-1.04 0l-9.071 5.99c-.26.173-.409.456-.409.757v13.183c0 .502.418.913.929.913h6.638c.511 0 .929-.41.929-.913v-7.075h3.008v7.075c0 .502.418.913.929.913h6.639c.51 0 .928-.41.928-.913V7.904c0-.301-.158-.584-.408-.758zM20 20l-4.5.01.011-7.097c0-.502-.418-.913-.928-.913H9.44c-.511 0-.929.41-.929.913L8.5 20H4V8.773l8.011-5.342L20 8.764z";
// const xHouse2 = "M21.591 7.146L12.52 1.157c-.316-.21-.724-.21-1.04 0l-9.071 5.99c-.26.173-.409.456-.409.757v13.183c0 .502.418.913.929.913H9.14c.51 0 .929-.41.929-.913v-7.075h3.909v7.075c0 .502.417.913.928.913h6.165c.511 0 .929-.41.929-.913V7.904c0-.301-.158-.584-.408-.758z";
// Checkmark
const blueCheckmark = "M20.396 11c-.018-.646-.215-1.275-.57-1.816-.354-.54-.852-.972-1.438-1.246.223-.607.27-1.264.14-1.897-.131-.634-.437-1.218-.882-1.687-.47-.445-1.053-.75-1.687-.882-.633-.13-1.29-.083-1.897.14-.273-.587-.704-1.086-1.245-1.44S11.647 1.62 11 1.604c-.646.017-1.273.213-1.813.568s-.969.854-1.24 1.44c-.608-.223-1.267-.272-1.902-.14-.635.13-1.22.436-1.69.882-.445.47-.749 1.055-.878 1.688-.13.633-.08 1.29.144 1.896-.587.274-1.087.705-1.443 1.245-.356.54-.555 1.17-.574 1.817.02.647.218 1.276.574 1.817.356.54.856.972 1.443 1.245-.224.606-.274 1.263-.144 1.896.13.634.433 1.218.877 1.688.47.443 1.054.747 1.687.878.633.132 1.29.084 1.897-.136.274.586.705 1.084 1.246 1.439.54.354 1.17.551 1.816.569.647-.016 1.276-.213 1.817-.567s.972-.854 1.245-1.44c.604.239 1.266.296 1.903.164.636-.132 1.22-.447 1.68-.907.46-.46.776-1.044.908-1.681s.075-1.299-.165-1.903c.586-.274 1.084-.705 1.439-1.246.354-.54.551-1.17.569-1.816zM9.662 14.85l-3.429-3.428 1.293-1.302 2.072 2.072 4.4-4.794 1.347 1.246z";
const goldCheckmark = "M13.324 3.848L11 1.6 8.676 3.848l-3.201-.453-.559 3.184L2.06 8.095 3.48 11l-1.42 2.904 2.856 1.516.559 3.184 3.201-.452L11 20.4l2.324-2.248 3.201.452.559-3.184 2.856-1.516L18.52 11l1.42-2.905-2.856-1.516-.559-3.184zm-7.09 7.575l3.428 3.428 5.683-6.206-1.347-1.247-4.4 4.795-2.072-2.072z";
const goldCheckmark2 = "M13.101 4.533L11 2.5 8.899 4.533l-2.895-.41-.505 2.88-2.583 1.37L4.2 11l-1.284 2.627 2.583 1.37.505 2.88 2.895-.41L11 19.5l2.101-2.033 2.895.41.505-2.88 2.583-1.37L17.8 11l1.284-2.627-2.583-1.37-.505-2.88zm-6.868 6.89l3.429 3.428 5.683-6.206-1.347-1.247-4.4 4.795-2.072-2.072z";
const goldCheckmark3 = "M6.233 11.423l3.429 3.428 5.65-6.17.038-.033-.005 1.398-5.683 6.206-3.429-3.429-.003-1.405.005.003z";
const grayCheckmark = "M12.05 2.056c-.568-.608-1.532-.608-2.1 0l-1.393 1.49c-.284.303-.685.47-1.1.455L5.42 3.932c-.832-.028-1.514.654-1.486 1.486l.069 2.039c.014.415-.152.816-.456 1.1l-1.49 1.392c-.608.568-.608 1.533 0 2.101l1.49 1.393c.304.284.47.684.456 1.1l-.07 2.038c-.027.832.655 1.514 1.487 1.486l2.038-.069c.415-.014.816.152 1.1.455l1.392 1.49c.569.609 1.533.609 2.102 0l1.393-1.49c.283-.303.684-.47 1.099-.455l2.038.069c.832.028 1.515-.654 1.486-1.486L18 14.542c-.015-.415.152-.815.455-1.099l1.49-1.393c.608-.568.608-1.533 0-2.101l-1.49-1.393c-.303-.283-.47-.684-.455-1.1l.068-2.038c.029-.832-.654-1.514-1.486-1.486l-2.038.07c-.415.013-.816-.153-1.1-.456zm-5.817 9.367l3.429 3.428 5.683-6.206-1.347-1.247-4.4 4.795-2.072-2.072z";

function replaceSVGs() {
  document.querySelectorAll(`g path`).forEach(svg => {
    if (svg.getAttribute("d") == xPath) {
      svg.setAttribute("d", birdPath)
    }
    if (svg.getAttribute("d") == goldCheckmark || svg.getAttribute("d") == goldCheckmark2 || svg.getAttribute("d") == goldCheckmark3 || svg.getAttribute("d") == grayCheckmark || svg.getAttribute("d") == blueCheckmark) {
      //svg.setAttribute("fill", "#FFFFFF")
      svg.setAttribute("fill", "#1D9BF0")
      svg.setAttribute("d", blueCheckmark)
    }
  })
}