let x = 10
let y = 20

let add x y = x + y

let z = add x y
printfn "%d" z

// Create a new tuple with updated values
let (x', y') = (15, 25)

// Recalculate z using new values
let z' = add x' y'
printfn "%d" z'