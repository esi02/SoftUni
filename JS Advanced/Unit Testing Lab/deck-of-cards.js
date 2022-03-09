function printDeckOfCards(cards) {
  function cardFactory() {
    let result = [];
    let isValid = true;
    let validFaces = [
      "2",
      "3",
      "4",
      "5",
      "6",
      "7",
      "8",
      "9",
      "10",
      "J",
      "Q",
      "K",
      "A",
    ];
    let validSuits = {
      S: "\u2660",
      H: "\u2665",
      D: "\u2666",
      C: "\u2663",
    };

    for (const card of cards) {
      let face = "";
      let suit = "";
      if (card.split("").length == 3) {
        face = card.split("")[0];
        face += card.split("")[1];
        suit = card.split("")[2];
      } else {
        face = card.split("")[0];
        suit = card.split("")[1];
      }

      if (!validFaces.includes(face) || validSuits[suit] == undefined) {
        console.log(`Invalid card: ${card}`);
        isValid = false;
      } else {
        result.push(`${face}${validSuits[suit]}`);
      }
    }
    if (isValid) {
      return result;
    } else {
        return false;
    }
  }
  if (cardFactory(cards) != false) {
      console.log(cardFactory(cards).join(" "));
  }
}

printDeckOfCards(["5S", "3D", "QD", "1C"]);
