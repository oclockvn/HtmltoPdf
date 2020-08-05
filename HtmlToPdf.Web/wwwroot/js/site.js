// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
Chart.plugins.unregister(ChartDataLabels);

//Function.prototype.bind = Function.prototype.bind || function (thisp) {
//    var fn = this;
//    return function () {
//        return fn.apply(thisp, arguments);
//    };
//};

// Write your Javascript code.
var barChartData = {
    labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
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
    for (var i = 0; i < canvases.length; i++) {
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
                }
            }
        });
    }

    new Chart(document.getElementById('bill-now-chart').getContext('2d'), {
        type: 'doughnut',
        plugins: [ChartDataLabels],
        data: {
            datasets: [{
                data: [100],
                backgroundColor: ['#4D80B0'],
                weight: 1,
                datalabels: { display: false }
            }, {
                data: [20, 40, 30],
                backgroundColor: ['#d8d8d8', '#e8e8e8', '#f6f6f6',],
                weight: 5,
                datalabels: {
                    formatter: function (value, context) {
                        return context.chart.data.labels[context.dataIndex] + ' ' + value;
                    }
                }
            }],
            labels: [
                'Usage',
                'Demand',
                'Fixed',
            ]
        },
        options: {
            legend: { display: false },
            label: { display: false },
            cutoutPercentage: 20
        }
    });

    new Chart(document.getElementById('bill-after-chart').getContext('2d'), {
        type: 'doughnut',
        plugins: [ChartDataLabels],
        data: {
            datasets: [{
                data: [60, 40],
                backgroundColor: ['transparent', '#7DD80C'],
                weight: 1,
                datalabels: { display: false }
            }, {
                data: [60, 40],
                backgroundColor: ['#4D80B0', 'transparent'],
                weight: 1,
                datalabels: { display: false }
            }, {
                data: [20, 40, 30],
                backgroundColor: ['#d8d8d8', '#e8e8e8', '#f6f6f6',],
                weight: 4,
                datalabels: {
                    formatter: function (value, context) {
                        return context.chart.data.labels[context.dataIndex] + ' ' + value;
                    }
                }
            }],
            labels: [
                'Usage',
                'Demand',
                'Fixed',
            ]
        },
        options: {
            legend: { display: false },
            label: { display: false },
            cutoutPercentage: 20
        }
    });
};
