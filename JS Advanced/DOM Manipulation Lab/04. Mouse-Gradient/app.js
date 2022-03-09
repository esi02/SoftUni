function attachGradientEvents() {
    let gradientElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');
    
    gradientElement.addEventListener('mousemove', (e) => {
        let resultPercentage = Math.floor((e.offsetX / e.target.offsetWidth) * 100);
        
        resultElement.textContent = `${resultPercentage}%`;
    });


}