class Story {
    #comments = [];
    #likes = [];
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
    }
    get likes() {
        if (this.#likes.length == 0) {
            return `${this.title} has 0 likes`;
        }else if(this.#likes.length == 1) {
            return `${this.#likes[0]} likes this story!`;
        } else {
            return `${this.#likes[0]} and ${this.#likes.length - 1} others like this story!`;
        }
    }
    like(username) {
        let like = this.#likes.find(x => x == username);
        if (like != undefined) {
            throw new Error("You can't like the same story twice!");
        } else if(like == this.creator) {
            throw new Error("You can't like your own story!");
        }
        this.#likes.push(username);
        return `${username} liked ${this.title}!`;
    }
    dislike(username) {
        let like = this.#likes.find(x => x == username);
        if (like == undefined) {
            throw new Error("You can't dislike this story!");
        }
        let index = this.#likes.indexOf(like);
        this.#likes.splice(index, 1);
        return `${username} disliked ${this.title}`;
    }
    comment(username, content, id) {
        let comment = this.#comments.find(x => x.Id == id);
        if (id == undefined || comment == undefined) {
            let newComment = { 
                Id: this.#comments.length + 1,
                Username: username,
                Content: content,
                Replies: []
            };
            this.#comments.push(newComment);
            return `${username} commented on ${this.title}`;
        }else {
            comment.Replies.push({
                Id: `${comment.Id}.${comment.Replies.length + 1}`,
                Username: username,
                Content: content
            });

            return `You replied successfully`;
        }
    }
    toString(sortingType) {
        if (sortingType == 'asc') {
            this.#comments.sort((a, b) => a.Id - b.Id);
            for (const comment of this.#comments) {
                comment.Replies.sort((a, b) => a.Id - b.Id);
            }
        } else if(sortingType == 'desc') {
            this.#comments.sort((a, b) => b.Id - a.Id);
            for (const comment of this.#comments) {
                comment.Replies.sort((a, b) => b.Id - a.Id);
            }
        } else if(sortingType == 'username') {
            this.#comments.sort((a, b) => a.Username.localeCompare(b.Username));
            for (const comment of this.#comments) {
                comment.Replies.sort((a, b) => a.Username.localeCompare(b.Username));
            }
        }
        let result = [];
        result.push(`Title: ${this.title}`);
        result.push(`Creator: ${this.creator}`);
        result.push(`Likes: ${this.#likes.length}`);

        if (this.#comments.length == 0) {
            result.push(`Comments:`);
        } else {
            result.push(`Comments:`);
            for (const comment of this.#comments) {
                result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                for (const reply of comment.Replies) {
                    result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`);
                }
            }
        }

        return result.join('\n');
    }
}

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));
