import mysql from 'mysql';

const dbConfig = {        
    HOST: "localhost",
    PORT: 3306,
    USERNAME: "root",
    PASSWORD: "1234",
    DATABASE: "cloudbar",
}

const connection = mysql.createConnection({
    host: dbConfig.HOST,
    user: dbConfig.USERNAME,
    password: dbConfig.PASSWORD,
    database: dbConfig.DATABASE
});

connection.connect(err => {
    if(err) throw err;
    console.log(`Successfully connected to database ${dbConfig.DATABASE}.`);
});

export default connection;