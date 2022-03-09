function modify(input) {
    let objects = [];
    for (const element of input) {
        let command = element.split(' ')[0];
        
        if (command == 'create') {
            let str = element.split(' ')[1];
            create(str);
        } 

    }

    let modifier = {
        create: (str) => objects.push({name: str}),
    createInherits: (name, parentName) => objects[name] = Object.setPrototypeOf(objects[name], object[parentName]),
    set: (name, key, value) => objects[name][key] = value,
    print: (name) => ({
        let result = [];
        objects[name].forEach(key => {
            result.push(`${key}:${objects[name][key]}`);
    })
       
    }
}







modify(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']);

