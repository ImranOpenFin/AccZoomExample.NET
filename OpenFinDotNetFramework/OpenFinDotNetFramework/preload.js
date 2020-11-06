console.log("preload called");

document.addEventListener('click', evt => {
    const closestLink = evt.target.closest('a');
    if (closestLink && closestLink.target === '_blank') {
       evt.preventDefault();
       fin.Window.create({
           url: closestLink.href,
           name: '' + Date.now(),
           accelerator: {zoom:true},
           experimental: {
               childWindows: false
           }
       });
   }
});
