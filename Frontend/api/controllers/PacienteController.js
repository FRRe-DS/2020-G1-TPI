/**
 * PacienteController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
  
    store: async function(req,res){
        let paciente = {
          Nombre: req.body.nombre,
          Apellido: req.body.apellido,
          DNI: req.body.dni,
          FechaDeNacimiento: req.body.fechaNacimiento,
          Sexo: req.body.sexo,
          Correo: req.body.email,
          Telefono: req.body.telefono,
        }

        let formulario = await Paciente.create(paciente).fetch()
        return res.status(201).json(formulario)
    }
};

