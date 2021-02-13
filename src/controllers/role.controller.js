import Role from '../models/role.model';
import RoleService from '../services/role.service';
import lodash from 'lodash';

const metadata = {
    pruralName: 'roles',
    singularName: 'role'
}

const RoleController = {
    get: (_, res) => {
        RoleService.getAll((err, data) => {
            if (err)
                res.status(500).send({
                    message:
                        err.message || `Some error occurred while retrieving ${metadata.pruralName}.`
                });
            else res.send(data);
        });
    },
    getById: (req, res) => {
        RoleService.getById(req.params.id, (err, data) => {
            if (err)
                res.status(500).send({
                    message:
                        err.message || `Some error occurred while retrieving ${metadata.pruralName}.`
                });
            else if (data.length === 0) {
                res.status(404).send({
                    message:
                        `${metadata.singularName} not found.`
                });
            }
            else res.send(data);
        });
    },
    create: (req, res) => {        
        if (lodash.isEmpty(req.body)) {
            res.status(400).send({
                message: "Content can not be empty!"
            });
        }

        const role = {name: req.body.name};        

        RoleService.create(role, (err, data) => {
            if (err)
                res.status(500).send({
                    message:
                        err.message || `Some error occurred while creating the ${metadata.singularName}.`
                });
            else res.send(data);
        });
    },
    update: (req, res) => {
        if (lodash.isEmpty(req.body)) {
            res.status(400).send({
                message: "Content can not be empty!"
            });
        }

        RoleService.update(
            req.params.id,
            {...req.body},
            (err, data) => {
                console.log(err, data)
                if (err) {
                    if (err.kind === "not_found") {
                        res.status(404).send({
                            message: `Not found ${metadata.singularName} with id ${req.params.id}.`
                        });
                    } else {
                        res.status(500).send({
                            message: `Error updating ${metadata.singularName} with id ${req.params.id}`
                        });
                    }
                } else res.send(data);
            }
        );
    },
    delete: (req, res) => {
        RoleService.delete(req.params.id, (err, data) => {
            if (err) {
              if (err.kind === "not_found") {
                res.status(404).send({
                  message: `Not found ${metadata.singularName} with id ${req.params.id}.`
                });
              } else {
                res.status(500).send({
                    message: `Could not delete ${metadata.singularName} with id ${req.params.id}`
                });
              }
            } else res.send({ message: `${metadata.singularName} was deleted successfully!` });
          });
    }
}

export default RoleController;