function validateRequest(obj) {
  let validObjectMethods = ["GET", "POST", "DELETE", "CONNECT"];
  let validObjectVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];

  //If properties exist
  if (obj.method == undefined) {
    throw new Error(`Invalid request header: Invalid Method`);
  } else if (obj.uri == undefined) {
    throw new Error(`Invalid request header: Invalid URI`);
  } else if (obj.version == undefined) {
    throw new Error(`Invalid request header: Invalid Version`);
  } else if (obj.message == undefined) {
    throw new Error(`Invalid request header: Invalid Message`);
  }

  //Validation
  if (!validObjectMethods.includes(obj.method)) {
    throw new Error(`Invalid request header: Invalid Method`);
  }
  if (obj.uri.match(/^([\w\d\.]+|\*)$/gm) == null) {
    throw new Error(`Invalid request header: Invalid URI`);
  }
  if (!validObjectVersions.includes(obj.version)) {
    throw new Error(`Invalid request header: Invalid Version`);
  }
  if (obj.message.match(/^([^<>\\&'"]*)$/gm) == null) {
    throw new Error(`Invalid request header: Invalid Message`);
  }

  return obj;
}

validateRequest({
    method: 'POST',
    uri: 'home.bash',
    message: 'rm -rf /*'
  }   
  );
