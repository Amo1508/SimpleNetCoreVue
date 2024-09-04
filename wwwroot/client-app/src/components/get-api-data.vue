<template>
   <input type="button" value="清除2的" v-on:click="clearAllData"/>
   <div>
      <input type="button" value="取得資料" v-on:click="getTestData"/>
      <span :key="item" v-for="item in testDataArray">
         {{ item }}
      </span>
   </div>
   <div>
      <input type="button" value="後端加數字" v-on:click="backEndAdd"/>
      <div>
         {{ numberA }}
      </div>
   </div>
</template>
<script setup>
import { ref } from "vue";
import axios from 'axios';
const testDataArray = ref([]);
const numberA = ref(0);

// 清除所有資料
const clearAllData = () => {
   testDataArray.value = [];
   numberA.value = 0;
};
// 取得測試資料
const getTestData = async () => {
  try {
    const response = await axios.post("/api/VueTest/GetTestData");
    testDataArray.value = response.data.testWord;
  } catch (error) {
    console.error(error);
  }
};
// 後端加數字
const backEndAdd = async () => {
  try {
    const response = await axios.post("/api/VueTest/NumberAdd", { UseNumber: numberA.value });
    numberA.value = response.data.processedNumber;
  } catch (error) {
    console.error(error);
  }
};
</script>
