var brick = {
    xpos: 0,
    ypos: 0,
    xvel: 0,
    yvel: 0,
    move: function() {
        xpos += xvel;
        ypos += yvel;
    }
};


var n = 100;
var sample = [];
for (var i = 0; i < n; i++)
    sample.push({
        xpos: Math.random() * 200,
        ypos: Math.random() * 750,
        xvel: 0,
        yvel: Math.random() * 3,
        width: 10,
        height: 10,
        move: function() {
            this.xpos += this.xvel;
            this.ypos += this.yvel;
        },

        draw: function() {

            var c = document.getElementById("myCanvas");

            var ctx = c.getContext("2d");

            ctx.fillRect(this.xpos, this.ypos, this.width, this.height);

        }
    });

for (var j = 0; j < sample.length; j++) {
    sample[j].draw();
};


setInterval(UpdateBrick, 200);

function UpdateBrick() {
    for (var j = 0; j < sample.length; j++) {
        sample[j].move();
        sample[j].draw();
    };
}

