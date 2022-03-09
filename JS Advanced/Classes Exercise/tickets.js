function sortingTickets(arrOfTickets, sortingCriteria) {
  let arrOfTicketObjects = [];

  class Ticket {
    constructor(destination, price, status) {
      this.destination = destination;
      this.price = price;
      this.status = status;
    }
  }

  for (const ticket of arrOfTickets) {
    let destination = ticket.split("|")[0];
    let price = Number(ticket.split("|")[1]);
    let status = ticket.split("|")[2];

    arrOfTicketObjects.push(new Ticket(destination, price, status));
  }

  switch (sortingCriteria) {
    case "destination":
      arrOfTicketObjects.sort(
        function (firstTicket, secondTicket) {
            return firstTicket.destination.localeCompare(secondTicket.destination);
        });
      break;
    case "price":
      arrOfTicketObjects.sort(
        (firstTicket, secondTicket) => firstTicket.price - secondTicket.price
      );
      break;
    case "status":
      arrOfTicketObjects.sort(function (firstTicket, secondTicket) {
        return firstTicket.status.localeCompare(secondTicket.status);
      });
      break;
  }

  return arrOfTicketObjects;
}

console.log(sortingTickets(
  [
    "Philadelphia|94.20|available",
    "New York City|95.99|available",
    "New York City|95.99|sold",
    "Boston|126.20|departed",
  ],
  "destination"
));
