// #Warnings
//<Expects status="Error" id="FS0039">The field, constructor or member 'ello' is not defined. Maybe you want one of the following: Hello</Expects>

type MyRecord = { Hello: int; World: bool}

let r = { Hello = 2 ; World = true}

let x = r.ello

exit 0