open PrivateConstructorAssembly

let record1 = HasPrivateConstructor.create "Hello, world!"
let record2 = HasPrivateConstructor.create "Hello, world!"

printfn "%A" (record1 = record2)
