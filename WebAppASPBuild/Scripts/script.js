ctx = document.querySelector("#frequency-chart");
console.log(ctx);
new Chart(ctx, {
    type: "line",
    data: {
        labels: ["1", "2", "3", "4"],
        datasets: [
            {
                label: "my chart",
                data: [50, 50, 50, 50],
                borderWidth: 1,
            },
        ],
    },
    option: {
        scales: {
            y: {
                beginAtZero: true,
            },
        },
        responsive: true,
    },
});

ctb = document.querySelector("#voltage-chart");
console.log(ctb);
new Chart(ctb, {
    type: "line",
    data: {
        labels: ["1", "2", "3", "4"],
        datasets: [
            {
                label: "avarage",
                data: [381, 381, 381, 381],
                borderWidth: 1,
            },
        ],
    },
    option: {
        scales: {
            y: {
                beginAtZero: true,
            },
        },
        responsive: true,
    },
});
cta = document.querySelector("#current-chart");
console.log(cta);
new Chart(cta, {
    type: "line",
    data: {
        labels: ["1", "2", "3", "4"],
        datasets: [
            {
                label: "current",
                data: [460, 459, 461, 458],
                borderWidth: 1,
            },
        ],
    },
    option: {
        scales: {
            y: {
                beginAtZero: true,
            },
        },
        legend: {
            display: false,
        },
        responsive: true,
    },
});
cta = document.querySelector("#consumption-chart");
console.log(cta);
new Chart(cta, {
    type: "bar",
    data: {
        labels: ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"],
        datasets: [
            {
                label: "consumption",
                data: [61, 52, 53, 52, 56, 62, 64, 63, 61, 60],
                borderWidth: 1,
            },
        ],
    },
    option: {
        scales: {
            y: {
                beginAtZero: true,
            },
        },

        responsive: true,
    },
});
cta = document.querySelector("#consumption2-chart");
console.log(cta);
new Chart(cta, {
    type: "bar",
    data: {
        labels: [
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "05:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
        ],
        datasets: [
            {
                label: "consumption2",
                data: [160, 165, 160, 180, 340, 341, 343, 350, 347, 330, 0, 0, 0, 0, 0],
                borderWidth: 1,
            },
        ],
    },
    options: {
        scales: {
            y: {
                beginAtZero: 1, // Đặt giá trị bắt đầu từ 0 hoặc true nếu muốn bắt đầu từ 0
            },
        },
        responsive: true,
    },
});
cta = document.querySelector("#current2-chart");
console.log(cta);
new Chart(cta, {
    type: "line",
    data: {
        labels: [
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
        ],
        datasets: [
            {
                label: "p1",
                data: [
                    330, 332, 331, 340, 500, 570, 600, 660, 630, 600, 500, 500, 500, 500,
                    500,
                ],
                borderWidth: 1,
            },
            {
                label: "p2",
                data: [
                    200, 220, 230, 250, 280, 280, 285, 290, 260, 270, 300, 300, 300, 300,
                    300,
                ],
                borderWidth: 1,
            },
            {
                label: "p3",
                data: [
                    250, 260, 265, 280, 300, 300, 310, 350, 340, 350, 400, 400, 400, 400,
                    400,
                ],
                borderWidth: 1,
            },
        ],
    },
    options: {
        scales: {
            y: {
                beginAtZero: 1, // Đặt giá trị bắt đầu từ 0 hoặc true nếu muốn bắt đầu từ 0
            },
        },
        responsive: true,
    },
});

Chart.resize(100, 200);
