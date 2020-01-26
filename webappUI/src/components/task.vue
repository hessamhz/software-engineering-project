<template>
    <v-app class="grey lighten-5">
        <v-content>
            <toolbar></toolbar>
            <v-layout row>
            <v-flex lg2>
            <navbar></navbar>
            </v-flex>
            <v-flex lg10>
            <v-container width="120vw" fluid>
                <v-container class="ml-0 mt-2 mb-6 mr-0">
                    <span class="text-lg-left font-weight-bold font-weight-black" style="font-size: xx-large">Task</span>
                </v-container>

                <v-container fluid>
                    <tasktable></tasktable>
                </v-container>
                <v-container fluid>
                        <v-card width="79vw" height="70vh">
                            <v-card-text class="font-weight-bold font-weight-black">Task Definition</v-card-text>
                            <v-form ref="form"
                                    v-model="valid"
                                    lazy-validation>
                            <v-row class="mr-2 ml-2">
                                <v-col cols=12 lg="4" md="4" >
                                    <v-text-field
                                            label="Task Name"
                                            :rules="[rules.required]"
                                            outlined
                                            dense
                                            v-model="taskname"
                                            hint="Required"
                                            color="#7cfc00"
                                            class="mb-4 mt-3"
                                    ></v-text-field>
                                    <v-text-field
                                            label="Task Creation Date"
                                            :rules="[rules.required]"
                                            outlined
                                            dense
                                            :value="taskcreationdate"
                                            v-model="taskcreationdate"
                                            color="#7cfc00"
                                    >
                                        <template v-slot:append>
                                            <v-menu
                                                    lazy
                                                    :close-on-content-click="false"
                                                    transition="scale-transition"
                                                    offset-y
                                            >
                                                <template v-slot:activator="{ on }">
                                        <v-btn text icon v-on="on">
                                            <v-icon>mdi-calendar</v-icon>
                                        </v-btn>
                                                </template>
                                                <v-date-picker v-model="taskcreationdate" no-title scrollable actions color="grey">
                                                </v-date-picker>
                                            </v-menu>
                                        </template>
                                    </v-text-field>


                                </v-col>
                                <v-col cols=12 lg="4" md="4">

                                    <v-select :items="categories" outlined color="7#cfc00" ::rules="[rules.required]" dense class="mb-4 mt-3" label="Task Category" placeholder="Electronics" v-model="taskcategory"></v-select>

                                    <v-select v-model="taskregion" :items="regions" outlined color="7#cfc00" :rules="[rules.required]" dense placeholder="Molestias"></v-select>

                                </v-col>
                                <v-col cols=12 lg="4" md="4">
                                    <v-text-field
                                            label="Task Sub Category"
                                            placeholder="Electronics"
                                            v-model="subcategory"
                                            outlined
                                            dense
                                            hint="optional"
                                            color="#7cfc00"
                                            class="mb-4 mt-3"
                                    ></v-text-field>
                                    <v-text-field
                                            label="Task Recommended Price"
                                            placeholder="100$"
                                            v-model="taskrecommendedprice"
                                            outlined
                                            dense
                                            hint="optional"
                                            color="#7cfc00"
                                            class="mb-4 mt-3"
                                    ></v-text-field>
                                </v-col>
                            </v-row>
                            <v-spacer></v-spacer>
                            <v-row class="mr-2 ml-2">
                                <v-col cols="12" md="6">
                                    <v-textarea
                                            outlined
                                            name="input-7-4"
                                            label="Task Description"
                                            hint="optional"
                                            v-model="taskdescription"
                                            color="#7cfc00"
                                    ></v-textarea>
                                </v-col>
                                <v-col cols="12" md="6">
                                    <v-textarea
                                            outlined
                                            name="input-7-4"
                                            label="Task Image"
                                            hint="optional"
                                            color="#7cfc00"
                                    ></v-textarea>
                                </v-col>
                            </v-row>
                            <v-spacer>
                            </v-spacer>
                            <v-row class="justify-end">
                                <v-col cols="12" lg="2">
                                <v-btn style="text-transform: initial;" :class="[!valid ? 'ml-10 grey lighten-3 grey--text' : 'buttoncolor']" text @click="validate()"  :disabled="!valid"> Submit Task</v-btn>
                                    <v-snackbar
                                            v-model="snackbar"
                                            :multi-line="multiLine"
                                            class="white"
                                    >
                                        Task Submitted successfully ! You can see the offers and continue by clicking on
                                        in the table above.
                                        <v-spacer></v-spacer>
                                        <v-icon size="20px" color="white">mdi-cellphone-information</v-icon>
                                        <v-btn
                                                color="#7cfc00"
                                                text
                                                @click="snackbar = false"
                                        >
                                            Close
                                        </v-btn>
                                    </v-snackbar>
                                </v-col>
                            </v-row>
                            </v-form>
                        </v-card>
                </v-container>
            </v-container>

            </v-flex>
            </v-layout>
        </v-content>
    </v-app>
</template>

<script>
    import Toolbar from "./toolbar";
    import Navbar from "./navbar";
    import Tasktable from "./tasktable";

    export default {
        name: "task",
        components: {Tasktable, Navbar, Toolbar},
        data () {
            return {
                e1: 1,
                n: 1,
                dates: null,
                click: 0,
                valid: false,
                snackbar: false,
                taskdefinition: 0,
                taskdescription: '',
                subcategory: '',
                taskname: '',
                taskregion: '',
                taskrecommendedprice: '',
                taskcategory: '',
                taskcreationdate: '',
                taskenddate: '',
                taskstatus: 'Task is Defined',
                complete: ['true','False','False','False'],
                categories: ['task1', 'task2', 'task3'],
                regions: ['region1', 'region2'],
                rules: {
                    required: value => !!value || 'Required.',
                }
            }
        },
        methods: {
            addnewtask(){
                console.log("we are here");
                var task = null;
                var len = this.$store.state.tasks.length + 1;
                task = { taskname: this.taskname, taskcategory: this.taskcategory, tasksubcategory: this.subcategory,
                    taskrecommondedprice: this.taskrecommondedprice , taskregion: this.taskregion , taskcreationdate: this.taskcreationdate, taskenddate: this.taskenddate, taskstatus: this.taskstatus ,
                    taskdescription: this.taskdescription, taskaction: "", taskinfo: '', e1: 1, taskid: len,
                };

                this.$store.commit('addTask', task);
                console.log("we are here2");
                console.log(task);
                console.log(this.$store.state.tasks);
            },
            validate () {
                if (this.$refs.form.validate()) {
                    this.addnewtask();
                    this.snackbar = true;
                }
            },

        },
        mounted(){
        },
        computed: {
            addtask: function() {
                return this.$store.state.activateaddtask;
            }

        },

    }
</script>

<style scoped>
.buttoncolor{
    background-color: #7cfc00;
    color: white;
}
</style>