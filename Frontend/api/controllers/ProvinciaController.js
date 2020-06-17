/**
 * ProvinciaController
 *
 * @description :: Server-side actions for handling incoming requests.
 * @help        :: See https://sailsjs.com/docs/concepts/actions
 */

module.exports = {
  list: async function(req,res){
    let provincia = await Provincias.find()

    return res.status(200).json(provincia)
  }

};

