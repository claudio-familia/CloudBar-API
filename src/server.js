import express from 'express';
import bodyParser from 'body-parser';

const app = express();
const port = 3000;


app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

require("./routes/role.routes.js")(app);

app.get('/', (req, res) => {
    res.send('Welcome to CloudBar-API');
});

app.listen(port, function(){
    console.log(`CloudBar-API is running on port ${port}`)
});