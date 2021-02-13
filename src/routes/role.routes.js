import RoleController from '../controllers/role.controller';

module.exports = app => {
    app.get("/roles", RoleController.get);
    app.get("/roles/:id", RoleController.getById);
    app.post("/roles", RoleController.create);
    app.put("/roles/:id", RoleController.update);
    app.delete("/roles/:id", RoleController.delete);
};