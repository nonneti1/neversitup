export function countSmileyFace(inputString: string[]): number {
    const regex = new RegExp(/^[:;][-~]?[)D]/);

    let totalSmileCount = 0;

    for (const data of inputString) {
        const isSmile = regex.test(data);
        if (isSmile == true) totalSmileCount++;
    }

    return totalSmileCount;
}

const input = [';D', ':-(', ':-)', ';~)'];
const result = countSmileyFace(input);
console.log(result);