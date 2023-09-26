const app = require("./src/app");
const port = 1999;

const server = app.listen(port, () => {
    console.log(`WS start with port: ${port}`);
})

process.on('SIGINT', () => {
    server.close( ()=> console.log(`Exit server express`));
})



