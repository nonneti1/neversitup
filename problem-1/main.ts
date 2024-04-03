function swap(strArr: string[], i: number, j: number): void {
    const temp: string = strArr[i];
    strArr[i] = strArr[j];
    strArr[j] = temp;
}

export function findPermutations(str: string, n: number = str.length, strArr: string[] = str.split('')): string[] {
    const result: string[] = [];

    if (n === 1) {
        result.push(strArr.join(''));
    } else {
        for (let i = 0; i < n; i++) {
            result.push(...findPermutations(str, n - 1, strArr));
            if (n % 2 === 0) {
                swap(strArr, i, n - 1);
            } else {
                swap(strArr, 0, n - 1);
            }
        }
    }

    return result;
}

const inputString: string = "abc";
const permutations: string[] = findPermutations(inputString);
console.log(permutations);
