class ArtGallery {
    possibleArticles = {
        picture:200,
        photo:50,
        item: 250
    };
    listOfArticles = [];
    guests = [];

    constructor(creator) {
        this.creator = creator;
    }

    addArticle(articleModel, articleName, quantity) {
        let element = this.listOfArticles.find(x => x.articleModel == articleModel);
        articleModel = articleModel.toLowerCase();

        if (!this.possibleArticles[articleModel]) {
            throw new Error("This article model is not included in this gallery!");
        }

        if (element != undefined) {
            element.quantity += quantity;
        } else {
            this.listOfArticles.push({
                articleModel,
                articleName,
                quantity
            });

            return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;
        }
    }

    inviteGuest(guestName, personality) {
        let guest = this.guests.find(x => x.guestName == guestName);

        if (guest != undefined) {
            throw new Error(`${guestName} has already been invited.`);
        }

        if (personality == 'Vip') {
            this.guests.push({
                guestName,
                points: 500,
                purchaseArticle: 0
            });
        } else if(personality == 'Middle') {
            this.guests.push({
                guestName,
                points: 250,
                purchaseArticle: 0
            });
        } else {
            this.guests.push({
                guestName,
                points: 50,
                purchaseArticle: 0
            });
        }

        return `You have successfully invited ${guestName}!`;
    }

    buyArticle(articleModel, articleName, guestName) {
        let guest = this.guests.find(x => x.guestName == guestName);
        let article = this.listOfArticles.find(x => x.articleName == articleName);

        if (article == undefined || article.articleModel != articleModel) {
            throw new Error("This article is not found.");
        }

        if (article.quantity == 0) {
            return `The ${articleName} is not available.`;
        }

        if (guest == undefined) {
            return "This guest is not invited.";
        }

        if (guest.points >= this.possibleArticles[article.articleModel]) {
            guest.points -= this.possibleArticles[article.articleModel];
            article.quantity--;
            guest.purchaseArticle++;

            return `${guestName} successfully purchased the article worth ${this.possibleArticles[article.articleModel]} points.`;
        } else {
            return "You need to more points to purchase the article.";
        }
    }

    showGalleryInfo(criteria) {
        let result = [];

        if (criteria == 'article') {
            result.push('Articles information:');
            this.listOfArticles.forEach(x => result.push(`${x.articleModel} - ${x.articleName} - ${x.quantity}`));
        } else if(criteria == 'guest') {
            result.push('Guests information:');
            this.guests.forEach(x => result.push(`${x.guestName} - ${x.purchaseArticle}`));
        }

        return result.join('\n');
    }
}

const artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));



