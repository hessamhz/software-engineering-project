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
                            <v-card width="79vw" height="20vh">
                                <v-card-text class="font-weight-bold font-weight-black">Task Status Bar</v-card-text>
                                <v-stepper></v-stepper>
                            </v-card>
                        </v-container>
                        <v-container fluid>
                            <v-card width="79vw" height="65vh"></v-card>
                        </v-container>
                    </v-container>
                </v-flex>
            </v-layout>
        </v-content>
    </v-app>
</template>

<script>
    export default {
        name: "panellayout"
    }
</script>

<style scoped>

</style>