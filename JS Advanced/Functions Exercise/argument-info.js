function info(argument1, argument2, argument3) {
  let result = [];
  let counts = [];

  result.push({
    type: typeof argument1,
    value: argument1,
  });

  result.push({
    type: typeof argument2,
    value: argument2,
  });

  result.push({
    type: typeof argument3,
    value: `${argument3}`,
  });

  result.forEach((x) => {

    if (counts[x.type] == x.type) {
        counts[x.type][count]++;
    }
      counts.push({
        type: x.type,
        count: 0
      })

  }
  );

  for (const obj of result) {
    for (const obj1 of counts) {
      if (obj.type == obj1.type) {
        obj1.count += 1;
      }
    }
  }

  result.forEach((x) => console.log(`${x.type}: ${x.value}`));
  counts.filter((x) => x.counts !== 0);
  counts.forEach((x) => console.log(`${x.type} = ${x.count}`));
}

info({ name: 'bob'}, 3.333, 9.999);
