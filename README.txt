Errores TP4:
Excepción no controlada en errores de bd
Dónde van los reclamos?
Si se instancia una exception, que sea una particular (propia o de sistema) no un throw new Exception. También, conservar la innerexception
VerificarConexion para qué esta? Abre y cierra la conexión, repite el connection string.. no se comprende la utilidad
Al cargar un pedido no se guarda el cliente, al consultar pedidos no se ven tampoco
La pantalla de Lista de pedidos es poco clara, botones para cargar de bd, cosa que hace al iniciar pero lee otra lista.. Darle sentido

Correcciones TP4:

Se agrega una excepción propia para no lanzar Exception genéricas cuando
se trabaja con la base de datos.

PDF aclara donde se guardan los archivos (carpeta debug del proyecto Vista) 

Los métodos de extensión ahora tienen una utilidad más clara.

Al agregar un pedido este se agrega también a la base de datos.

FrmListadoPedidos mejorado. Se trabaja siempre con la base de datos para
evitar tener dos listas distintas. Esto tambien corrige la excepcion no controlada.

