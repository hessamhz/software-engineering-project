<template>
    <v-card width="79vw">
        <v-card-title>
            Tasks
            <v-spacer></v-spacer>
            <v-btn text icon><v-icon color="#7cfc00" @click="activetaskadd()">mdi-plus-thick</v-icon></v-btn>
            <small>add task</small>
        </v-card-title>
        <v-data-table
                :headers="headers"
                :items="desserts"
        >
            <template v-slot:item.taskaction="{ item }">
                <v-layout row>
                <v-btn text icon>
                    <v-icon color="#7cfc00" size="20px">mdi-lead-pencil</v-icon>
                </v-btn>
                <v-btn text icon>
                <v-icon color="red" size="20px">mdi-trash-can-outline</v-icon>
                </v-btn>
                </v-layout>
            </template>
            <template v-slot:item.taskinfo="{ item }">
                <v-btn text icon class="ml-4" @click="clicked(item.taskid)" :to="{path: '/eachtask', query: {taskid: item.taskid}}">
                    <v-icon color="black" size="20px">mdi-cellphone-information</v-icon>
                </v-btn>
            </template>
        </v-data-table>

    </v-card>
</template>

<script>
    export default {
        name: "tasktable",
        data () {
            return {
                taskid: 0,
                x: false,
                headers: [
                    {
                        text: 'Task Name',
                        align: 'left',
                        sortable: false,
                        value: 'taskname',
                    },
                    { text: 'Task Name', value: 'taskname' },
                    { text: 'Task Category', value: 'taskcategory' },
                    { text: 'Task Sub Category', value: 'tasksubcategory' },
                    { text: 'Task Recommonded Price', value: 'taskrecommondedprice' },
                    { text: 'Task Region', value: 'taskregion' },
                    { text: 'Task Creation Date', value: 'taskcreationdate' },
                    { text: 'Task End Date', value: 'taskenddate' },
                    { text: 'Task Status', value: 'taskstatus' },
                    { text: 'Task Description', value: 'taskdescription' },
                    { text: 'Task Action', value: 'taskaction' },
                    { text: 'Task Info', value: 'taskinfo' },
                ],
                desserts: []
            }
        },
        methods: {
            clicked(i){
                this.x = true;
                console.log(this.x);
                console.log(i);
            },
            gettasks (){
                var tasks = null;
                tasks = new Array(this.$store.state.tasks.length);

                tasks = this.$store.state.tasks;
                console.log(tasks);
                return tasks;
            },
            activetaskadd() {
                var t = true;
                console.log(t);
                this.$store.state.commit('activeadd',t);
            }

        },
        mounted() {
            this.desserts = this.gettasks();
        }
    }
</script>

<style scoped>

</style>