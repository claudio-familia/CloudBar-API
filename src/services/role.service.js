import connection from '../config/mysql-config';

const tableName = 'roles';
const singularName = 'role';

const RoleService = {
    getAll: (handler) => {
        connection.query(`SELECT * FROM ${tableName}`, (error, response) => {
            if(error){
                console.error(error);
                handler(error, null);
                return;
            }

            console.log(`${tableName} `, response);
            handler(null, response);
        })
    },
    getById: (id, handler) => {
        connection.query(`SELECT * FROM ${tableName} WHERE id = ${id}`, (error, response) => {
            if(error){
                console.error(error);
                handler(error, null);
                return;
            }

            console.log(`${singularName} `, response);
            handler(null, response);
        })
    },
    create: (newItem, handler) => {
        connection.query(`INSERT INTO ${tableName} SET ?`, newItem, (err, res) => {
            if (err) {
              console.log("error: ", err);
              handler(err, null);
              return;
            }
        
            console.log(`created ${singularName}: `, { id: res.insertId, ...newItem });
            handler(null, { id: res.insertId, ...newItem });
          });
    },
    update: (id, item, handler) => {
        connection.query(
            `UPDATE ${tableName} SET name = ? WHERE id = ?`,
            [item.name, id],
            (err, res) => {
              if (err) {
                console.log("error: ", err);
                handler(err, null);
                return;
              }
        
              if (res.affectedRows == 0) {                
                handler({ kind: "not_found" }, null);
                return;
              }
        
              console.log(`updated ${singularName}: `, { id: id, ...item });
              handler(null, { id: id, ...item });
            }
          );
    },
    delete: (id, handler) => {
        connection.query(`DELETE FROM ${tableName} WHERE id = ?`, id, (err, res) => {
            if (err) {
              console.log("error: ", err);
              handler(err, null);
              return;
            }
        
            if (res.affectedRows == 0) {              
              handler({ kind: "not_found" }, null);
              return;
            }
        
            console.log(`deleted ${singularName} with id: `, id);
            handler(null, res);
          });
    }
}

export default RoleService;