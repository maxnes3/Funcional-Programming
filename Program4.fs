module Program4

type IEmployee =
    abstract member Name: string
    abstract member ID: int
    abstract member GetDetails: unit -> string

type Employee(name: string, id: int) =
    interface IEmployee with
        member this.Name = name
        member this.ID = id
        member this.GetDetails() = sprintf "Employee: %s, ID: %d" name id

type Manager(name: string, id: int, department: string) =
    inherit Employee(name, id)
    member this.Department = department
    interface IEmployee with
        member this.GetDetails() = sprintf "Manager: %s, ID: %d, Department: %s" name id department

type HRDepartment() =
    let mutable employees: IEmployee list = []
    member this.AddEmployee(employee: IEmployee) =
        employees <- employee :: employees
    member this.GetAllEmployees() =
        employees |> List.map (fun e -> e.GetDetails())