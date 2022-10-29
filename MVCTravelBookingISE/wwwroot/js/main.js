const triggers = [
    $(document).ready(function () {
        $('[data-toggle="popover"]').popover();
    });

//line
var ctxL = document.getElementById("lineChart1").getContext('2d');
var myLineChart = new Chart(ctxL, {
    type: 'line',
    data: {
        labels: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October"],
        datasets: [{
            pointBackgroundColor: '#fff',
            backgroundColor: 'transparent',
            borderColor: 'rgba(255, 255, 255)',
            data: [2500, 2550, 5000, 3100, 7000, 5500, 4950, 16000, 10500, 8000],
        }]
    },
    options: {
        legend: {
            display: false
        },
        scales: {
            xAxes: [{
                gridLines: {
                    display: false,
                    color: "transparent",
                    zeroLineColor: "transparent"
                },
                ticks: {
                    fontColor: "#fff",
                },
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    display: true,
                    drawBorder: false,
                    color: "rgba(255,255,255,.25)",
                    zeroLineColor: "rgba(255,255,255,.25)"
                },
                ticks: {
                    fontColor: "#fff",
                    beginAtZero: true,
                    stepSize: 5000
                },
            }],
        }
    }
});

// Minimalist charts
$(function () {
    $('.min-chart#chart-pageviews').easyPieChart({
        barColor: "#3059B0",
        onStep: function (from, to, percent) {
            $(this.el).find('.percent').text(Math.round(percent));
        }
    });
    $('.min-chart#chart-downloads').easyPieChart({
        barColor: "#3059B0",
        onStep: function (from, to, percent) {
            $(this.el).find('.percent').text(Math.round(percent));
        }
    });
    $('.min-chart#chart-sales').easyPieChart({
        barColor: "#3059B0",
        onStep: function (from, to, percent) {
            $(this.el).find('.percent').text(Math.round(percent));
        }
    });
});

var ctxL = document.getElementById("lineChart").getContext('2d');
var myLineChart = new Chart(ctxL, {
    type: 'line',
    data: {
        labels: ["January", "February", "March", "April", "May", "June", "July"],
        datasets: [{
            label: "My First dataset",
            fillColor: "#fff",
            backgroundColor: 'rgba(255, 255, 255, .3)',
            borderColor: 'rgba(255, 255, 255)',
            data: [0, 10, 5, 2, 20, 30, 45],
        }]
    },
    options: {
        legend: {
            labels: {
                fontColor: "#fff",
            }
        },
        scales: {
            xAxes: [{
                gridLines: {
                    display: true,
                    color: "rgba(255,255,255,.25)"
                },
                ticks: {
                    fontColor: "#fff",
                },
            }],
            yAxes: [{
                display: true,
                gridLines: {
                    display: true,
                    color: "rgba(255,255,255,.25)"
                },
                ticks: {
                    fontColor: "#fff",
                },
            }],
        }
    }
});

$(function () {
    var selectedClass = "";
    $(".filter").click(function () {
        selectedClass = $(this).attr("data-rel");
        $("#gallery").fadeTo(100, 0.1);
        $("#gallery div").not("." + selectedClass).fadeOut().removeClass('animation');
        setTimeout(function () {
            $("." + selectedClass).fadeIn().addClass('animation');
            $("#gallery").fadeTo(300, 1);
        }, 300);
    });
});



$('#multi13').mdbRange({
    single: {
        active: true,
        counting: true,
        countingTarget: '#ex'
    }
});

$('#multi14').mdbRange({
    single: {
        active: true,
        counting: true,
        countingTarget: '.ex1'
    }
});