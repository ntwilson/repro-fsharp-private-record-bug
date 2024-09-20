namespace PrivateConstructorAssembly

type HasPrivateConstructor = private { Message : string }

module HasPrivateConstructor = 
  let create message = { Message = message }

