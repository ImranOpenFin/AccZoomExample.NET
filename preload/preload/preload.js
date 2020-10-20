console.log("preload called");

document.addEventListener('click', evt => {
   if (evt.target.target === '_blank') {
       evt.preventDefault();
       fin.Window.create({
           url: evt.target.href,
           name: '' + Date.now(),
           accelerator: { zoom: true }
       });
   }
});