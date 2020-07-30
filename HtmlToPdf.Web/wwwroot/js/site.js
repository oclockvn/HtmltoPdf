// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

Function.prototype.bind = Function.prototype.bind || function (thisp) {
    var fn = this;
    return function () {
        return fn.apply(thisp, arguments);
    };
};

// Write your Javascript code.
var MONTHS = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
var barChartData = {
    labels: [...MONTHS, ...MONTHS],
    datasets: [{
        label: 'Dataset 1',
        backgroundColor: '#f44336',
        borderColor: '#333',
        borderWidth: 1,
        data: [
            5, 10, 15, 12, 24, 30, 59, 30, 60, 12, 4, 6, 8, 41, 34, 56, 74, 24, 23, 11, 46, 67, 65, 50, 22, 23, 25, 62, 67, 52, 26, 48, 33, 32, 21
        ]
    }]

};

window.onload = function () {
    var canvases = document.querySelectorAll(".chart");
    for (let i = 0; i < canvases.length; i++) {
        var canvas = canvases[i];

        var ctx = canvas.getContext('2d');
        new Chart(ctx, {
            type: 'bar',
            data: barChartData,
            options: {
                responsive: true,
                legend: {
                    position: 'top',
                },
                title: {
                    display: true,
                    text: 'Sample Chart'
                },
                animation: {
                    onComplete: function() {
                        console.log(`canvas render completed`);
                        //canvas.parentElement.querySelector('img').src = canvas.toDataURL();
                    }
                }
            }
        });
    }

};

//"javascript:(document.querySelectorAll('canvas').forEach(canvas => { var data = canvas.getAttribute('data-chart'); document.querySelector(`img[data-chart=${data}]`).src = canvas.toDataURL(); }))"
