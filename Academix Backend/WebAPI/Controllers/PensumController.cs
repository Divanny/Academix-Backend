﻿using Data.Administration;
using Models.Administration;
using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Infraestructure;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Pensum")]
    public class PensumController : ApiBaseController
    {
        PensumRepo pensumRepo = new PensumRepo();

        /// <summary>
        /// Obtiene un listado de los pensum registrados.
        /// </summary>
        /// <returns></returns>
        // GET api/Pensum
        [HttpGet]
        //[Autorizar(AllowAnyProfile = true)]
        public List<PensumModel> Get()
        {
            return pensumRepo.Get().ToList();
        }

        /// <summary>
        /// Obtiene un pensum en específico.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/Pensum/5
        [HttpGet]
        //[Autorizar(AllowAnyProfile = true)]
        public PensumModel Get(int id)
        {
            return pensumRepo.Get(x => x.idPensum == id).FirstOrDefault();
        }

        /// <summary>
        /// Agrega un nuevo pensum (se necesita permiso de administrador).
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        // POST api/Pensum
        [HttpPost]
        //[Autorizar(AllowAnyProfile = true)]
        public OperationResult Post([FromBody] PensumModel model)
        {
            if (ValidateModel(model))
            {


                var created = pensumRepo.Add(model);
                pensumRepo.SaveChanges();
                return new OperationResult(true, "Se ha creado este pensum satisfactoriamente", created);
            }
            else
            {
                return new OperationResult(false, "Los datos ingresados no son válidos", Validation.Errors);
            }
        }

        /// <summary>
        /// Actualiza la información de un pensum.
        /// </summary>
        /// <param name="idPensum"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        // PUT api/Pensum/5
        [HttpPut]
        //[Autorizar(AllowAnyProfile = true)]
        public OperationResult Put(int idPensum, [FromBody] PensumModel model)
        {
            if (ValidateModel(model))
            {
                PensumModel pensum = pensumRepo.Get(x => x.idPensum == idPensum).FirstOrDefault();

                if (pensum == null)
                {
                    return new OperationResult(false, "Este pensum no existe.");
                }





                pensumRepo.Edit(model, idPensum);
                return new OperationResult(true, "Se ha actualizado satisfactoriamente");
            }
            else
            {
                return new OperationResult(false, "Los datos ingresados no son válidos", Validation.Errors);
            }
        }
    }
}