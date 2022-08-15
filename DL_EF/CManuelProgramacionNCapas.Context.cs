﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CManuelProgramacionNCapasEntities : DbContext
    {
        public CManuelProgramacionNCapasEntities()
            : base("name=CManuelProgramacionNCapasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aseguradora> Aseguradoras { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Colonia> Colonias { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Poliza> Polizas { get; set; }
        public virtual DbSet<SubPoliza> SubPolizas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual ObjectResult<AseguradoraGetById_Result> AseguradoraGetById(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetById_Result>("AseguradoraGetById", idAseguradoraParameter);
        }
    
        public virtual int AseguradoraUpdate(string nombre, Nullable<int> idAseguradora, Nullable<int> idUsuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraUpdate", nombreParameter, idAseguradoraParameter, idUsuarioParameter);
        }
    
        public virtual int AseguradoraAdd(string nombre, Nullable<int> idUsuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraAdd", nombreParameter, idUsuarioParameter);
        }
    
        public virtual int AseguradoraDelete(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraDelete", idAseguradoraParameter);
        }
    
        public virtual int UsuarioAdd(string nombre, string apellidoPaterno, string apellidoMaterno, string sexo, string curp, string userName, string email, string telefono, string celular, string fechaNacimiento, string imagen, Nullable<int> idRol, Nullable<bool> estatus, string password, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(bool));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, sexoParameter, curpParameter, userNameParameter, emailParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, imagenParameter, idRolParameter, estatusParameter, passwordParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idUsuarioParameter);
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int UsuarioUpdate(Nullable<int> idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, string sexo, string curp, string userName, string email, string telefono, string celular, string fechaNacimiento, string imagen, Nullable<int> idRol, Nullable<bool> estatus, string password, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia, Nullable<int> idDireccion)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(bool));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            var idDireccionParameter = idDireccion.HasValue ?
                new ObjectParameter("IdDireccion", idDireccion) :
                new ObjectParameter("IdDireccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", idUsuarioParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, sexoParameter, curpParameter, userNameParameter, emailParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, imagenParameter, idRolParameter, estatusParameter, passwordParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter, idDireccionParameter);
        }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter);
        }
    
        public virtual ObjectResult<AseguradoraGetAll_Result> AseguradoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetAll_Result>("AseguradoraGetAll");
        }
    
        public virtual ObjectResult<ColoniaGetByIdMunicipio_Result> ColoniaGetByIdMunicipio(Nullable<int> idMunicipio)
        {
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("IdMunicipio", idMunicipio) :
                new ObjectParameter("IdMunicipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ColoniaGetByIdMunicipio_Result>("ColoniaGetByIdMunicipio", idMunicipioParameter);
        }
    
        public virtual int EmpleadoAdd(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, string fechaNacimiento, string nSS, string fechaIngreso, string foto, Nullable<int> idEmpresa, Nullable<int> idPoliza)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso != null ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAdd", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter, idPolizaParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetAll_Result> EmpleadoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetAll_Result>("EmpleadoGetAll");
        }
    
        public virtual ObjectResult<EmpleadoGetById_Result> EmpleadoGetById(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetById_Result>("EmpleadoGetById", idEmpleadoParameter);
        }
    
        public virtual int EmpleadoUpdate(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, string fechaNacimiento, string nSS, string fechaIngreso, string foto, Nullable<int> idEmpresa, Nullable<int> idPoliza, Nullable<int> idEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento != null ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(string));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso != null ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoUpdate", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter, idPolizaParameter, idEmpleadoParameter);
        }
    
        public virtual int EmpresaAdd(string nombre, string telefono, string email, string direccionWeb, string logo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var direccionWebParameter = direccionWeb != null ?
                new ObjectParameter("DireccionWeb", direccionWeb) :
                new ObjectParameter("DireccionWeb", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("Logo", logo) :
                new ObjectParameter("Logo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaAdd", nombreParameter, telefonoParameter, emailParameter, direccionWebParameter, logoParameter);
        }
    
        public virtual int EmpresaDelete(Nullable<int> idEmpresa)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaDelete", idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpresaGetAll_Result> EmpresaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetAll_Result>("EmpresaGetAll");
        }
    
        public virtual ObjectResult<EmpresaGetById_Result> EmpresaGetById(Nullable<int> idEmpresa)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetById_Result>("EmpresaGetById", idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpresaNombreGetAll_Result> EmpresaNombreGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaNombreGetAll_Result>("EmpresaNombreGetAll");
        }
    
        public virtual int EmpresaUpdate(string nombre, string telefono, string email, string direccionWeb, string logo, Nullable<int> idEmpresa)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var direccionWebParameter = direccionWeb != null ?
                new ObjectParameter("DireccionWeb", direccionWeb) :
                new ObjectParameter("DireccionWeb", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("Logo", logo) :
                new ObjectParameter("Logo", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaUpdate", nombreParameter, telefonoParameter, emailParameter, direccionWebParameter, logoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<EstadoGetByIdPais_Result> EstadoGetByIdPais(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetByIdPais_Result>("EstadoGetByIdPais", idPaisParameter);
        }
    
        public virtual ObjectResult<MunicipioGetByIdEstado_Result> MunicipioGetByIdEstado(Nullable<int> idEstado)
        {
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MunicipioGetByIdEstado_Result>("MunicipioGetByIdEstado", idEstadoParameter);
        }
    
        public virtual ObjectResult<PaisGetAll_Result> PaisGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetAll_Result>("PaisGetAll");
        }
    
        public virtual ObjectResult<PolizaNombreGetAll_Result> PolizaNombreGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PolizaNombreGetAll_Result>("PolizaNombreGetAll");
        }
    
        public virtual int PolizaAdd(string nombre, string numeroPoliza, string fechaCreacion, string fechaModificacion, Nullable<int> idUsuario, Nullable<int> idSubPoliza)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var numeroPolizaParameter = numeroPoliza != null ?
                new ObjectParameter("NumeroPoliza", numeroPoliza) :
                new ObjectParameter("NumeroPoliza", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion != null ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(string));
    
            var fechaModificacionParameter = fechaModificacion != null ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idSubPolizaParameter = idSubPoliza.HasValue ?
                new ObjectParameter("IdSubPoliza", idSubPoliza) :
                new ObjectParameter("IdSubPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaAdd", nombreParameter, numeroPolizaParameter, fechaCreacionParameter, fechaModificacionParameter, idUsuarioParameter, idSubPolizaParameter);
        }
    
        public virtual int PolizaUpdate(string nombre, string numeroPoliza, string fechaCreacion, string fechaModificacion, Nullable<int> idUsuario, Nullable<int> idSubPoliza, Nullable<int> idPoliza)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var numeroPolizaParameter = numeroPoliza != null ?
                new ObjectParameter("NumeroPoliza", numeroPoliza) :
                new ObjectParameter("NumeroPoliza", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion != null ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(string));
    
            var fechaModificacionParameter = fechaModificacion != null ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idSubPolizaParameter = idSubPoliza.HasValue ?
                new ObjectParameter("IdSubPoliza", idSubPoliza) :
                new ObjectParameter("IdSubPoliza", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaUpdate", nombreParameter, numeroPolizaParameter, fechaCreacionParameter, fechaModificacionParameter, idUsuarioParameter, idSubPolizaParameter, idPolizaParameter);
        }
    
        public virtual int PolizaDelete(Nullable<int> idPoliza)
        {
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaDelete", idPolizaParameter);
        }
    
        public virtual ObjectResult<PolizaGetAll_Result> PolizaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PolizaGetAll_Result>("PolizaGetAll");
        }
    
        public virtual ObjectResult<PolizaGetById_Result> PolizaGetById(Nullable<int> idPoliza)
        {
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PolizaGetById_Result>("PolizaGetById", idPolizaParameter);
        }
    }
}
