/**
 * PacienteController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
  
    list: async function(req,res){
        let pacientes = await Paciente.find()
        return res.status(200).json(pacientes)
  
        //let pacientes = global_pacientes
        //return res.status(200).json(pacientes)
    },
  
    store: async function(req,res){
      let data = {
          dni: req.body.dni,
          apellido: req.body.apellido,
          nombre: req.body.nombre,
          fechanac: req.body.fechanac,
          edad: req.body.edad,
          sexo: req.body.sexo,
          email: req.body.email,
          telefono: req.body.telefono,
          otros: req.body.otros
      }
  
      let form = await Paciente.create(data).fetch()
      return res.status(201).json(form)
    },

    delete: async function(req,res){
        let id = req.params.id

        let pacientes = await Paciente.destroyOne({id: id})

        return res.json(pacientes)
    }
};

