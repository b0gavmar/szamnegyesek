<template>
  <div class="game-container">
    <div class="grid">
      <div v-for="(row, rowIndex) in table" :key="rowIndex" class="row">
        <div v-for="(cell, colIndex) in row" :key="colIndex" class="cell">
          {{ cell }}
        </div>
      </div>
    </div>
    <div class="buttons">
      <button @click="increaseTable('A')">A</button>
      <button @click="increaseTable('B')">B</button>
      <button @click="increaseTable('C')">C</button>
      <button @click="increaseTable('D')">D</button>
      <button @click="resetTable">Reset</button>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue';

const table = ref([
  [0, 0, 0],
  [0, 0, 0],
  [0, 0, 0]
])

const increaseTable = (region) =>{
  if (region === 'A') {
    updateCells([[0, 0], [0, 1], [1, 0], [1, 1]]);
  } else if (region === 'B') {
    updateCells([[0, 1], [0, 2], [1, 1], [1, 2]]);
  } else if (region === 'C') {
    updateCells([[1, 0], [1, 1], [2, 0], [2, 1]]);
  } else if (region === 'D') {
    updateCells([[1, 1], [1, 2], [2, 1], [2, 2]]);
  }
};
const updateCells = (cells) => {
  cells.forEach(([r, c]) => {
    table.value[r][c]++;
  });
};

const resetTable = () => {
  table.value = [
    [0, 0, 0],
    [0, 0, 0],
    [0, 0, 0]
  ];
};

</script>

<style scoped>
.game-container {
  text-align: center;
}
.grid {
  display: inline-block;
}
.row {
  display: flex;
}
.cell {
  width: 50px;
  height: 50px;
  border: 1px solid black;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  margin: 2px;
}
.buttons {
  margin-top: 10px;
}
button {
  margin: 5px;
  padding: 10px;
  font-size: 16px;
}
</style>
