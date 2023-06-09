﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseConsoleClient.CoursesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/CoursesServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CoursesServiceReference.ICourses", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICourses {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourses/AddToCourses", ReplyAction="http://tempuri.org/ICourses/AddToCoursesResponse")]
        void AddToCourses(CourseConsoleClient.CoursesServiceReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourses/AddToCourses", ReplyAction="http://tempuri.org/ICourses/AddToCoursesResponse")]
        System.Threading.Tasks.Task AddToCoursesAsync(CourseConsoleClient.CoursesServiceReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/ICourses/ListCourses", ReplyAction="http://tempuri.org/ICourses/ListCoursesResponse")]
        CourseConsoleClient.CoursesServiceReference.Course[] ListCourses();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/ICourses/ListCourses", ReplyAction="http://tempuri.org/ICourses/ListCoursesResponse")]
        System.Threading.Tasks.Task<CourseConsoleClient.CoursesServiceReference.Course[]> ListCoursesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICoursesChannel : CourseConsoleClient.CoursesServiceReference.ICourses, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoursesClient : System.ServiceModel.ClientBase<CourseConsoleClient.CoursesServiceReference.ICourses>, CourseConsoleClient.CoursesServiceReference.ICourses {
        
        public CoursesClient() {
        }
        
        public CoursesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoursesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoursesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoursesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddToCourses(CourseConsoleClient.CoursesServiceReference.Course course) {
            base.Channel.AddToCourses(course);
        }
        
        public System.Threading.Tasks.Task AddToCoursesAsync(CourseConsoleClient.CoursesServiceReference.Course course) {
            return base.Channel.AddToCoursesAsync(course);
        }
        
        public CourseConsoleClient.CoursesServiceReference.Course[] ListCourses() {
            return base.Channel.ListCourses();
        }
        
        public System.Threading.Tasks.Task<CourseConsoleClient.CoursesServiceReference.Course[]> ListCoursesAsync() {
            return base.Channel.ListCoursesAsync();
        }
    }
}
